namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama - Esto originalmente solo obtendría el numero de letras.
            //Creo un array para guardar las palabras
            string[] palabras;
            //Uso el metodo split para separar cuando haya un espacio cada palabra
            palabras = textoTelegrama.Split(' ');
            //El total de strings en el array es la cantidad de palabras que tendremos
            numPalabras = palabras.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    //Faltaba el calculo completo
                    coste = 2.5 + (0.5 * (numPalabras - 10));
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    //Faltaba el parentesis para la operación
                    coste = 5 + (0.75 * (numPalabras - 10));
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}