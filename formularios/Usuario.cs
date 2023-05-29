using System;

public class Usuario
{

    private string nome;
    public string cpf;
    public string sexo;
    public string senha;
    public string GetNome()
    {
        return nome;
    }

    public string Getcpf()
    {
        return cpf;
    }

    public string Getsexo()
    {
        return sexo;
    }
    public string Getsenha()
    {
        return senha;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }
    public void SetCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public void SetSexo(string sexo)
    {
        this.sexo= sexo;
    }
    public void SetSenha(string senha)
    {
        this.senha = senha;
    }
}
