namespace ponaT3.Vistas;

public partial class vInicio : ContentPage
{
	public vInicio()
	{
		InitializeComponent();
	}
    private void btnParcial1_Clicked(object sender, EventArgs e)
    {
        double seg1 = Convert.ToDouble(txtNotaSeg.Text);
        double exa1 = Convert.ToDouble(txtNotaExa.Text);

        double seg2 = Convert.ToDouble(txtNotaSeg2.Text);
        double exa2 = Convert.ToDouble(txtNotaExa2.Text);



        double parcial1 = seg1 * 0.3 + exa1 * 0.2;
        double parcial2 = seg2 * 0.3 + exa2 * 0.2;

        double promedio = parcial1 + parcial2;

        string resultado = "REPROBADO";

        if (promedio >= 7)
        {

            resultado = "APROBADO";
        }
        else if (promedio >= 5 && promedio >= 6.9)
        {
            resultado = "COMPLEMENTARIO";
        }

        //Se imprime en pantalla
        DisplayAlert("Notas", "Bienvenid@ ",
            $"Nombre: {pkAlumnos.SelectedItem} \n" +
            $"Fecha:{dpFecha.Date.ToString("dd/MM/yyyy")}\n" +
            $"Nota Parcial 1: {parcial1} \n" +
            $"Nota Parcial 2: {parcial2} \n" +
            $"Nota Final: {promedio} \n" +
            $"Estado: {resultado} \n");




    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        lblFecha.Text = "La fecha selecionada es " + fecha;
    }
}