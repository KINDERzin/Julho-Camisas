namespace Julhocamisas;

public partial class Funcionario{

    String Nome;
    String Email;
    String Endereco;

    public Funcionario()
    {

    }

    public void SetNome(String n)
    {
        Nome = n;
    }

    public void SetEmail(String e)
    {
        Email = e;
    }

    public void SetEndereco(String e)
    {
        Endereco = e;
    }

    public String GetNome()
    {
        return Nome;
    }

    public String GetEmail()
    {
        return Email;
    }

    public String GetEndereco()
    {
        return Endereco;
    }

}