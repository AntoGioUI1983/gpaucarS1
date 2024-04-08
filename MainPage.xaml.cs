namespace gpaucarS1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad=Convert.ToInt32(txtEdad.Text);
            double sueldo = Convert.ToInt32(txtSalario.Text);
            double iess = ((9.45) * sueldo)/100;
            DisplayAlert("Bienvenido\n","Infomación afiliado\n" + nombre+" "+apellido+"\nEdad: "+edad+"\nSueldo mensual $: "+sueldo+"\nAportes IESS $: "+iess,"Cerrar");
        } 

    }
}
