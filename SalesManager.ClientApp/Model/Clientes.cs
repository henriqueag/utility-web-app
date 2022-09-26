using SistemaVendas.DAO;
using System;
using System.Data;
using System.Linq;

namespace SistemaVendas.Model
{
    public class Clientes
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime Data_Nasc { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public readonly ClienteDAO _clienteDAO = new ClienteDAO();

        public Clientes ()
        {
        }

        public Clientes (int id, string nome, string cpf, DateTime data_Nasc, string telefone, string email = "")
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Data_Nasc = data_Nasc;
            Telefone = telefone;
            Email = email;
        }

        public DataTable SelectAll ()
        {
            return _clienteDAO.SelectAll();
        }

        public DataTable FiltroCliente(string busca)
        {
            return _clienteDAO.FiltroCliente(busca);
        }

        public Clientes BuscaPorId (int id)
        {
            return _clienteDAO.BuscaPorId(id);
        }

        public override string ToString ()
        {
            return $"{Id} - {Nome} - {CPF} - {Data_Nasc:dd/MM/yyyy} - {Telefone}";
        }
    }
}
