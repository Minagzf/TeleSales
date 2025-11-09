Imports System.Data.SqlClient


Module Module1
    Public con As New SqlConnection("Password=000;Persist Security Info=True;User ID=sa;
                                        Initial Catalog=TeleSales;Data Source=.")
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
End Module
