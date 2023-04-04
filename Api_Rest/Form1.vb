Imports Newtonsoft.Json

Public Class Form1
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        Dim api = New DBApi
        Dim headers = New List(Of Parametro)
        Dim parametros = New List(Of Parametro)
        Dim url = "https://api.openweathermap.org/data/2.5/weather?lat=" + txt_lat.Text + "&lon=" + txt_lon.Text + "&units=metric&lang=es&appid=15a203f469c6350d478c797e331fc6c6"

        Dim consulta = api.MGet(url, headers, parametros)
        Dim objeto = JsonConvert.DeserializeObject(Of Clima)(consulta)
        txt_temp.Text = objeto.main.temp
        txt_presion.Text = objeto.main.pressure
        txt_Hum.Text = objeto.main.humidity

    End Sub
End Class
