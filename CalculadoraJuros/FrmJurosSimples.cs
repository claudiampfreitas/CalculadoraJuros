using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraJuros
{
	
    public partial class FrmJurosSimples : Form
	{
		public FrmJurosSimples()
		{
			InitializeComponent();
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{

				bool jurosEntrada = double.TryParse(txtjuros.Text, out double juros);
				bool taxaEntrada = double.TryParse(txttaxa.Text, out double taxas);
				double taxa=taxas / 100;
				bool periodoEntrada = double.TryParse(txtperiodo.Text, out double periodo);
				
				double capital = juros/(taxa*periodo);
				txtcapital.Text = Math.Round(capital, 2).ToString();
			}

			if (optjuros.Checked==true)
			{
				bool taxaEntrada = double.TryParse(txttaxa.Text, out double taxa);
				double taxas=taxa / 100;
				bool periodoEntrada = double.TryParse(txtperiodo.Text, out double periodo);
				bool capitalEntrada = double.TryParse(txtcapital.Text, out double capital);
				
				double juros = capital*taxa*periodo;
				txtjuros.Text = Math.Round(juros, 2).ToString();
			}
			if (optperiodo.Checked==true)
			{
				bool taxaEntrada = double.TryParse(txttaxa.Text, out double taxa);
				double taxas=taxa / 100;
				bool capitalEntrada = double.TryParse(txtcapital.Text, out double capital);
				bool jurosEntrada = double.TryParse(txtjuros.Text, out double juros);
				
				int periodo = (int)(juros/(capital*taxa));
				txtperiodo.Text = periodo.ToString();
			}
			if (opttaxa.Checked==true)
			{
				bool periodoEntrada = double.TryParse(txtperiodo.Text, out double periodo);
				bool capitalEntrada = double.TryParse(txtcapital.Text, out double capital);
				bool jurosEntrada = double.TryParse(txtjuros.Text, out double juros);
				
				double taxa = (juros/(capital*periodo)) * 100;
				txttaxa.Text = Math.Round(taxa, 2).ToString();
				
			}
		}
		void OptcapitalCheckedChanged(object sender, EventArgs e)
		{
			if (optcapital.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=true;
				txtcapital.Enabled=false;
			}
		}
		void OptjurosCheckedChanged(object sender, EventArgs e)
		{
			if (optjuros.Checked==true)
			{
				txtjuros.Enabled=false;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=true;
				txtcapital.Enabled=true;
			}
		}
		void FrmJurosSimplesShown(object sender, EventArgs e)
		{
			optjuros.Checked=false;
			optperiodo.Checked=false;
			optcapital.Checked=false;
			opttaxa.Checked=false;
			txtjuros.Enabled=false;
			txtperiodo.Enabled=false;
			txttaxa.Enabled=false;;
			txtcapital.Enabled=false;
		}
		void OptperiodoCheckedChanged(object sender, EventArgs e)
		{
			if (optperiodo.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=false;
				txttaxa.Enabled=true;
				txtcapital.Enabled=true;
			}
		}
		void OpttaxaCheckedChanged(object sender, EventArgs e)
		{
			if (opttaxa.Checked==true)
			{
				txtjuros.Enabled=true;
				txtperiodo.Enabled=true;
				txttaxa.Enabled=false;
				txtcapital.Enabled=true;
			}
		}
	}
}
