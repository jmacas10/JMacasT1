namespace JMacasT1.Vistas;

public partial class VPrincipal : ContentPage
{
	public VPrincipal()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
string nombre=txtNombre.Text;
        string apellido =txtApellido.Text;
        int edad = Convert.ToInt32(txtedad.Text);
        double salario=Convert.ToDouble(txtsalario.Text);
        double aporte= 9.45;
        double seguro = salario* aporte/100;
        DisplayAlert("Alerta", "Bienvenido  " + nombre +" "+apellido+"\nTienes " + edad + " Años "+ "\nTu aporte mensual al IESS es: " + seguro, "Cerrar");
    }
}