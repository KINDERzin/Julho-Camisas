namespace JulhoCamisas;

public partial class Forn_MateriaPrima{

    String Fornecedor;
    String MateriaPrima;
    int Preco;

    public Forn_MateriaPrima()
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

    public String GetFornecedor()
    {
        return Fornecedor;
    }

    public String GetMateriaPrima()
    {
        return MateriaPrima;
    }
}