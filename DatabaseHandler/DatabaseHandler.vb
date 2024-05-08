Imports System.Data.SqlClient
Imports Npgsql


Namespace DatabaseHandling
    'TODO:Switch to SQL lite
    Public Class DatabaseHandler

        Dim connString As String = "Host=172.27.200.231;Port=15432;Database=kmarco;Username=kmarco;Password=kmarco"


        Public Sub TestConnection()
            Dim flag As Boolean

            Using conn As New NpgsqlConnection(connString)
                Dim DBlist As List(Of String) = New List(Of String)
                Try
                    conn.Open()
                    Console.WriteLine("Connected to PostgreSQL database!")
                    flag = True
                Catch ex As Exception
                    Console.WriteLine("Failed to connect to PostgreSQL database: " & ex.Message)
                    flag = False
                End Try

                If flag Then


                End If

                Using command As New NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema='public' AND table_type='BASE TABLE';", conn)

                    Using reader As NpgsqlDataReader = command.ExecuteReader()
                        While reader.Read()

                            Dim listElement As String = reader.GetString(0)
                            DBlist.Add(listElement)
                        End While

                    End Using



                End Using
            End Using

        End Sub



        Public Function GetBlogPosts() As List(Of BlogPost)

            Dim posts As New List(Of BlogPost)()
            Using conn As New NpgsqlConnection(connString)
                Using command As New NpgsqlCommand("SELECT id, title, content FROM BlogPosts", conn)

                    Try
                        conn.Open()
                        'Console.WriteLine("Connected to PostgreSQL database!")
                    Catch ex As Exception
                        'Console.WriteLine("Failed to connect to PostgreSQL database: " & ex.Message)
                    End Try

                    'TODO: get all blog posts and return list of blog posts
                    Using reader As NpgsqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim post As New BlogPost()
                            post.Id = reader.GetInt32(0)
                            post.Title = Convert.ToString(reader.GetString(1))
                            'post.Content = Convert.ToString(reader.GetString(2))
                            'post.PostDate = Convert.ToDateTime(reader.GetDateTime(3))

                            posts.Add(post)
                        End While

                    End Using
                End Using
            End Using

            Return posts
        End Function

        Public Sub UpdatePost(ByVal blogpost As BlogPost)

            Using conn As New NpgsqlConnection(connString)
                Dim sqlCommand As String = "UPDATE BlogPosts SET title =" + blogpost.Title + ", content=" + blogpost.Content + "WHERE id =" + blogpost.Id + ";"
                Using command As New NpgsqlCommand(sqlCommand, conn)

                    Try
                        conn.Open()
                        'Console.WriteLine("Connected to PostgreSQL database!")
                    Catch ex As Exception
                        'Console.WriteLine("Failed to connect to PostgreSQL database: " & ex.Message)
                    End Try
                    command.ExecuteNonQuery()
                    'TODO: get all blog posts and return list of blog posts
                End Using

            End Using

        End Sub

        Public Sub AddPost(ByVal blogpost As BlogPost)

            Using conn As New NpgsqlConnection(connString)
                'error prone, replace with better string concatenation
                Dim sqlCommand As String = "INSERT INTO BlogPosts (id, title, content, postdate)  VALUES (" + blogpost.Id + ", '" + blogpost.Title + "', '" + blogpost.Content + "'," + Convert.ToString(blogpost.PostDate) + ";"
                Using command As New NpgsqlCommand(sqlCommand, conn)

                    Try
                        conn.Open()
                        'Console.WriteLine("Connected to PostgreSQL database!")
                    Catch ex As Exception
                        'Console.WriteLine("Failed to connect to PostgreSQL database: " & ex.Message)
                    End Try
                    command.ExecuteNonQuery()

                    'TODO: get all blog posts and return list of blog posts
                End Using

            End Using

        End Sub

        Public Sub DeletePost(ByVal postId As Integer)
            Dim sqlCommand As String = "DELETE FROM BlogPosts WHERE id = @id"

            Using conn As New NpgsqlConnection(connString)
                Using command As New NpgsqlCommand(SqlCommand, conn)
                    command.Parameters.AddWithValue("@PostID", postId)

                    conn.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        End Sub


    End Class
End Namespace