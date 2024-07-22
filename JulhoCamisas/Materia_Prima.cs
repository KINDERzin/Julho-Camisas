namespace JulhoCamisas;

public partial class Materia_Prima{

    String Fornecedor;
    String MateriaPrima;
    int Preco;

    public Materia_Prima()
    {

    }

    public void SetFornecedor(String f)
    {
        Fornecedor = f;
    }

    public void SetMateriaPrima(String m)
    {
        MateriaPrima = m;
    }

    public void SetPreco(int p)
    {
        Preco = p;
    }

    public String GetFornecedor()
    {
        return Fornecedor;
    }
    public String GetMateriaPrima()
    {
        return MateriaPrima;
    }
    public int GetPreco()
    {
        return Preco;
    }
}