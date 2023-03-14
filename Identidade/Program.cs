using Identidade;

string[] infos = new string[9];

PessoaFisica pf;

PessoaJuridica pj;

Console.Write("Pessoa Física (pf) ou Pessoa Jurídica (pj): ");
if (Console.ReadLine().Equals("pf"))
{
    Console.WriteLine("Digite o nome: ");
    infos[0] = Console.ReadLine();

    Console.WriteLine("Digite o endereço: ");
    infos[1] = Console.ReadLine();

    Console.WriteLine("Digite o telefone: ");
    infos[2] = Console.ReadLine();

    Console.WriteLine("Digite o telefone celular: ");
    infos[3] = Console.ReadLine();

    Console.WriteLine("Digite o email: ");
    infos[4] = Console.ReadLine();

    Console.WriteLine("Digite o cpf: ");
    infos[5] = Console.ReadLine();

    pf = new PessoaFisica(infos[0], infos[1], infos[2], infos[3], infos[4], infos[5]);
    Console.WriteLine(pf.ToString());
}
else
{
    Console.WriteLine("Digite o nome: ");
    infos[0] = Console.ReadLine();

    Console.WriteLine("Digite o endereço: ");
    infos[1] = Console.ReadLine();

    Console.WriteLine("Digite o telefone: ");
    infos[2] = Console.ReadLine();

    Console.WriteLine("Digite o telefone celular: ");
    infos[3] = Console.ReadLine();

    Console.WriteLine("Digite o email: ");
    infos[4] = Console.ReadLine();

    Console.WriteLine("Digite o nome fantasia: ");
    infos[5] = Console.ReadLine();
    
    Console.WriteLine("Digite o cnpj: ");
    infos[6] = Console.ReadLine();

    pj = new PessoaJuridica(infos[0], infos[1], infos[2], infos[3], infos[4], infos[5], infos[6]);
    Console.WriteLine(pj.ToString());
}

