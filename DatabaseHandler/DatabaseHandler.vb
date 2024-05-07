Imports System.Data.SqlClient
Imports Npgsql


Namespace DatabaseHandling
    Module DatabaseHandler
        Sub TestConnection()
            Dim connString As String = "Host=172.27.200.231;Port=5432;Database=kmarcodb;Username=kmarco;Password=kmarco"
            Using conn As New NpgsqlConnection(connString)
                Try
                    conn.Open()
                    Console.WriteLine("Connected to PostgreSQL database!")
                Catch ex As Exception
                    Console.WriteLine("Failed to connect to PostgreSQL database: " & ex.Message)
                End Try
            End Using
        End Sub
        Function GetBlogPosts() As List(Of BlogPost)
            Dim connString As String = "Host=172.27.200.231;Port=5432;Database=kmarcodb;Username=kmarco;Password=kmarco"

            Dim posts As New List(Of BlogPost)()
            Using conn As New NpgsqlConnection(connString)
                Using command As New NpgsqlCommand("SELECT ID, Title, Content, DateCreated FROM BlogPosts", conn)

                    Try
                        conn.Open()
                        Console.WriteLine("Connected to PostgreSQL database!")
                    Catch ex As Exception
                        Console.WriteLine("Failed to connect to PostgreSQL database: " & ex.Message)
                    End Try

                    'TODO: get all blog postts and return list of blog posts
                    Using reader As NpgsqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim post As New BlogPost()
                            post.Id = reader.GetInt32(0)
                            post.Title = reader.GetString(1)
                            post.Content = reader.GetString(2)
                            post.PostDate = reader.GetDateTime(3)

                            posts.Add(post)
                        End While

                    End Using
                End Using
            End Using

            Return posts
        End Function


    End Module
End Namespace