namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblFigura;
    ComboBox? cmbFiguras;
    Label? lblCalculo;
    ComboBox? cmbCalculo;
    Label? lblAltura;
    TextBox? txtAltura;
    Label? lblBase;
    TextBox? txtBase;
    Button? btnCalcular;
    Label? lblResultado;
    TextBox? txtResultado;
    Label? lbllado3;
    TextBox? txtlado3;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        cmbCalculo.SelectedItem = "Périmetro";
        cmbFiguras.SelectedItem = "Cuadrado";
        cmbFiguras.SelectedItem = "Triangulo";
    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300, 350);
        //Etiqueta "Figura"
        lblFigura = new Label();
        lblFigura.Text = "Figura";
        lblFigura.AutoSize = true;
        lblFigura.Location = new Point(10, 10);
        //Combobox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Location = new Point(10, 40);
        cmbFiguras.SelectedValueChanged += new EventHandler(cmbFiguras_ValueChanged);
        //Etiqueta "Cálculo"
        lblCalculo = new Label();
        lblCalculo.Text = "Cálculo";
        lblCalculo.AutoSize = true;
        lblCalculo.Location = new Point(150, 10);
        //Combobox Cálculos
        cmbCalculo = new ComboBox();
        cmbCalculo.Items.Add("Périmetro");
        cmbCalculo.Items.Add("Área");
        cmbCalculo.Location = new Point(150, 40);
        cmbCalculo.SelectedValueChanged += new EventHandler(cmbCalculo_ValueChanged);
        //Etiqueta "Altura"
        lblAltura = new Label();
        lblAltura.Text = "Altura";
        lblAltura.AutoSize = true;
        lblAltura.Location = new Point(10, 80);
        lblAltura.Visible=false;
        //TextBox Altura
        txtAltura = new TextBox();
        txtAltura.Size = new Size(100, 20);
        txtAltura.Location = new Point(60, 75);
        txtAltura.Visible=false;
        //Etiqueta "Base"
        lblBase = new Label();
        lblBase.Text = "Base";
        lblBase.AutoSize = true;
        lblBase.Location = new Point(10, 120);
        lblBase.Visible=false;
        //TextBox Base
        txtBase = new TextBox();
        txtBase.Size = new Size(100, 20);
        txtBase.Location = new Point(60, 115);
        txtBase.Visible=false;
        //Etiqueta lado3
        lbllado3 = new Label();
        lbllado3.Text = "C  ";
        lbllado3.AutoSize = true;
        lbllado3.Location = new Point(10, 150);
        lbllado3.Visible=false;
        //TextBox lado3
        txtlado3 = new TextBox();
        txtlado3.Size = new Size(100, 20);
        txtlado3.Location = new Point(60, 145);
        txtlado3.Visible=false;
        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(170, 200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);
        //Etiqueta "Resultado"
        lblResultado = new Label();
        lblResultado.Text = "Resultado";
        lblResultado.AutoSize = true;
        lblResultado.Location = new Point(10, 280);
        //TextBox Resultado
        txtResultado = new TextBox();
        txtResultado.Size = new Size(100, 20);
        txtResultado.Location = new Point(90, 275);

        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculo);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(lbllado3);
        this.Controls.Add(txtlado3);

    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculo.SelectedItem.ToString();
        string figuras= cmbFiguras.SelectedItem.ToString();
        int altura=0;
        if(calculo=="Périmetro"){
            if(figuras=="Cuadrado"){
                if(txtAltura.Text!="" && checarValores(txtAltura.Text)==true){
                    altura=Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*4).ToString();
                }
            }
            if(figuras=="Rectangulo"){
                if(txtAltura.Text!="" && txtBase.Text!="" && checarValores(txtAltura.Text)==true && checarValores(txtBase.Text)==true){
                    int ancho=Convert.ToInt32(txtBase.Text);
                    altura=Convert.ToInt32(txtAltura.Text);
                    int resultado=(2*ancho)+(2*altura);
                    txtResultado.Text=resultado.ToString();
                }
            }
            if(figuras=="Triangulo"){
                if(txtBase.Text!="" && checarValores(txtBase.Text)==true && checarValores(txtAltura.Text)==true && checarValores(txtlado3.Text)==true){
                    int a=Convert.ToInt32(txtAltura.Text);
                    int b=Convert.ToInt32(txtBase.Text);
                    int c=Convert.ToInt32(txtlado3.Text);
                    txtResultado.Text=(a+b+c).ToString();
                }
            }
        }
        if(calculo=="Área"){
            if(figuras=="Cuadrado"){
                if(txtAltura.Text!="" && checarValores(txtAltura.Text)==true){
                    altura=Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*altura).ToString();
                }
            }
            if(figuras=="Rectangulo"){
                if(txtAltura.Text!="" && txtBase.Text!="" && checarValores(txtAltura.Text)==true && checarValores(txtBase.Text)==true){
                    int ancho=Convert.ToInt32(txtBase.Text);
                    altura=Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*ancho).ToString();
                }
            }
            if(figuras=="Triangulo"){
                if(txtAltura.Text!="" && txtBase.Text!="" && checarValores(txtAltura.Text)==true && checarValores(txtBase.Text)==true){
                    int ancho=Convert.ToInt32(txtBase.Text);
                    altura=Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=((altura*ancho)/2).ToString();
                }
            }
        }
    }


    public Boolean checarValores(String checar){
        try{
            int valor=Convert.ToInt32(checar);
            return true;
        }catch(Exception e){
            return false;
        }
    }

    private void cmbFiguras_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            txtResultado.Text="";
            txtBase.Text="";
            txtAltura.Text="";
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }

            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible = true;
                txtBase.Visible = true;  
                lbllado3.Visible=true;
                txtlado3.Visible=true;
                        }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }

            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }
        }

    }
    private void cmbCalculo_ValueChanged(object sender, EventArgs e)
    {
        if (cmbFiguras.SelectedItem != null && cmbCalculo.SelectedItem != null)
        {
            txtResultado.Text="";
            txtBase.Text="";
            txtAltura.Text="";
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }

            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Périmetro")
            {
                lblAltura.Visible=true;
                txtAltura.Visible=true;
                lblBase.Visible = true;
                txtBase.Visible = true;  
                lbllado3.Visible=true;
                txtlado3.Visible=true;
                        }
            if (cmbFiguras.SelectedItem.ToString() == "Cuadrado" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = false;
                txtBase.Visible = false;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }
            if (cmbFiguras.SelectedItem.ToString() == "Rectangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }

            if (cmbFiguras.SelectedItem.ToString() == "Triangulo" && cmbCalculo.SelectedItem.ToString() == "Área")
            {
                lblAltura.Visible = true;
                txtAltura.Visible = true;
                lblBase.Visible = true;
                txtBase.Visible = true;
                lbllado3.Visible=false;
                txtlado3.Visible=false;
            }
        }
    }
}
