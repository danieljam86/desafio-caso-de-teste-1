using System.ComponentModel;

namespace desafio_caso_de_teste_1.Model
{
    public class Metodos
    {
        public static List<Produto> listaProdutos = new List<Produto>();
        public static List<Vendas> listaVendas = new List<Vendas>();
        public static List<Transfere> listaTransfere = new List<Transfere>();
        public static string[]? arquivosEntrada;
        public static string[]? arquivosSaida;
        public static string caminhoArquivosEntrada = AppDomain.CurrentDomain.BaseDirectory + "ArquivosEntrada\\";
        public static string caminhoArquivosSaida = AppDomain.CurrentDomain.BaseDirectory + "ArquivosSaida\\";


        public static string[] LerArquivosEntrada()
        {
            arquivosEntrada = System.IO.Directory.GetFiles(caminhoArquivosEntrada);
            return arquivosEntrada;
        }

        public static string[] LerArquivosSaida()
        {
            arquivosSaida = System.IO.Directory.GetFiles(caminhoArquivosSaida);
            return arquivosSaida;
        }

        public static List<Produto> LerArquivoProdutos(StreamReader arquivoProdutos)
        {
            string s;
            while ((s = arquivoProdutos.ReadLine()) != null)
            {
                Produto produtos = new Produto();
                string[] linha = s.Split(';');
                produtos.CodProduto = int.Parse(linha[0]);
                produtos.QtdeEstoqInicio = int.Parse(linha[1]);
                produtos.QtdeMinEstOpe = int.Parse(linha[2]);
                listaProdutos.Add(produtos);
            }
            return listaProdutos;
        }

        public static List<Produto> LerArquivoTransfere(StreamReader arquivoProdutos)
        {
            string s;
            while ((s = arquivoProdutos.ReadLine()) != null)
            {
                Transfere transfere = new Transfere();
                string[] linha = s.Split(';');
                transfere.CodProduto = int.Parse(linha[0]);
                transfere.QtdeEstoqInicio = int.Parse(linha[1]);
                transfere.QtdeMinEstOpe = int.Parse(linha[2]);
                transfere.QtVendas = 0;
                transfere.EstAposVenda = int.Parse(linha[1]);
                transfere.Necess = 0;
                transfere.TransfArmazempCo = 0;
                listaTransfere.Add(transfere);
            }
            return null;
        }

        public static List<Vendas> LerArquivoVendas(StreamReader arquivoVendas)
        {
            string s;
            while ((s = arquivoVendas.ReadLine()) != null)
            {
                Vendas venda = new Vendas();
                string[] linha = s.Split(';');
                venda.CodProduto = int.Parse(linha[0]);
                venda.QtdeVendida = int.Parse(linha[1]);
                venda.SituacaoVenda = int.Parse(linha[2]);
                venda.CanalVenda = int.Parse(linha[3]);
                listaVendas.Add(venda);
            }
            return listaVendas;
        }

        public static string SituacaoVenda(int sitVenda)
        {
            switch (sitVenda)
            {
                case 100:
                    return "Venda realizada";
                case 102:
                    return "Venda realizada, pagamento pendente";
                case 135:
                    return "Venda cancelada";
                case 190:
                    return "Venda não finalizada no canal de vendas";
                case 999:
                    return "Erro não identificado";                    
                default:
                    return "Erro não identificado";
            }
        }

        public static List<Transfere> CalculaQtdeVendaPorProduto(List<Vendas> listaVendas, List<Transfere> listaTransfere)
        {
            foreach(var venda in listaVendas)
            {
                foreach (var transfere in listaTransfere)
                {
                    if (venda.CodProduto == transfere.CodProduto)
                    {
                        transfere.EstAposVenda -= venda.QtdeVendida;
                        transfere.QtVendas += venda.QtdeVendida;
                        //while (transfere.EstAposVenda < transfere.QtdeEstoqInicio + transfere.Necess)
                        //{
                        //    transfere.Necess = transfere.EstAposVenda * -1;
                        //    transfere.TransfArmazempCo += transfere.Necess;
                        //    transfere.EstAposVenda += transfere.Necess;
                        //}
                    }
                }
            }
            foreach (var transfere in listaTransfere)
            {
                if (transfere.EstAposVenda < transfere.QtdeMinEstOpe)
                {
                    transfere.Necess = transfere.QtdeMinEstOpe - transfere.EstAposVenda;
                }
                if (transfere.Necess > 0 && transfere.Necess <= 10)
                {
                    transfere.TransfArmazempCo = 10;
                }
                else
                {
                    transfere.TransfArmazempCo = transfere.Necess;
                }
                
            }
            return listaTransfere;
        }


        public static void EscreverArquivo(string caminhoArquivo, string texto)
        {
            System.IO.File.WriteAllText(caminhoArquivo, texto);
        }
        

        public DataGridView Grade(DataGridView dg)
        {
            dg.EditMode = DataGridViewEditMode.EditProgrammatically;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.DefaultCellStyle.Font = new Font("Roboto", 9);
            dg.EnableHeadersVisualStyles = false; // Desabilita formatação padrão
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dg.ColumnHeadersHeight = 40;
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dg.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);
            dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.LightGray;
            dg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            //Vc pode usar um for se quiser 
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dg.MultiSelect = false;
            return dg;
        }
    }
}
