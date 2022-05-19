using desafio_caso_de_teste_1.Model;

namespace desafio_caso_de_teste_1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var arquivo in Metodos.LerArquivosEntrada())
            {
                StreamReader stream = new StreamReader(arquivo);
                StreamReader stream1 = new StreamReader(arquivo);
                if (arquivo.Contains("produtos"))
                {
                    Metodos.LerArquivoProdutos(stream);
                    Metodos.LerArquivoTransfere(stream1);
                }
                if (arquivo.Contains("vendas"))
                {
                    Metodos.LerArquivoVendas(stream);
                }
            }

            Metodos.listaTransfere = Metodos.CalculaQtdeVendaPorProduto(Metodos.listaVendas, Metodos.listaTransfere);


            dgvProdutos.ColumnCount = 3;
            dgvProdutos.Columns[0].Name = "CodProduto";
            dgvProdutos.Columns[1].Name = "QtdeEstoqInicio";
            dgvProdutos.Columns[2].Name = "QtdeMinEstOpe";
            var rows = new List<string[]>();
            foreach (Produto produto in Metodos.listaProdutos)
            {
                string[] row1 = new string[]
                {
                    produto.CodProduto.ToString(),
                    produto.QtdeEstoqInicio.ToString(),
                    produto.QtdeMinEstOpe.ToString(),
            };
                rows.Add(row1);
            }
            foreach (string[] rowarray in rows)
            {
                dgvProdutos.Rows.Add(rowarray);
            }



            dgvVendas.ColumnCount = 4;
            dgvVendas.Columns[0].Name = "CodProduto";
            dgvVendas.Columns[1].Name = "QtdeVendida";
            dgvVendas.Columns[2].Name = "SituacaoVenda";
            dgvVendas.Columns[3].Name = "CanalVenda";
            var rows2 = new List<string[]>();
            foreach (Vendas venda in Metodos.listaVendas)
            {
                string situacaoVenda = Metodos.SituacaoVenda(venda.SituacaoVenda);
                string[] row3 = new string[]
                {
                    venda.CodProduto.ToString(),
                    venda.QtdeVendida.ToString(),
                    situacaoVenda,
                    venda.CanalVenda.ToString(),
            };
                rows2.Add(row3);
            }
            foreach (string[] rowarray in rows2)
            {
                dgvVendas.Rows.Add(rowarray);
            }


            dgvTrasfere.ColumnCount = 7;
            dgvTrasfere.Columns[0].Name = "CodProduto";
            dgvTrasfere.Columns[1].Name = "QtdeEstoqInicio";
            dgvTrasfere.Columns[2].Name = "QtdeMinEstOpe";
            dgvTrasfere.Columns[3].Name = "QtadeVendas";
            dgvTrasfere.Columns[4].Name = "Est Após vendas";
            dgvTrasfere.Columns[5].Name = "Necessário repor";
            dgvTrasfere.Columns[6].Name = "Transf Armazem para CO";
            var rows3 = new List<string[]>();
            foreach (Transfere transfere in Metodos.listaTransfere)
            {
                string[] row4 = new string[]
                {
                    transfere.CodProduto.ToString(),
                    transfere.QtdeEstoqInicio.ToString(),
                    transfere.QtdeMinEstOpe.ToString(),
                    transfere.QtVendas.ToString(),
                    transfere.EstAposVenda.ToString(),
                    transfere.Necess.ToString(),
                    transfere.TransfArmazempCo.ToString(),
                };
                rows3.Add(row4);
            }


            foreach (string[] rowarray in rows3)
                {
                    dgvTrasfere.Rows.Add(rowarray);
                }

            
        }
    }
}