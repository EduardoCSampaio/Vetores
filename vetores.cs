using System;

namespace Vetoresronaldoeduardo
{
    class Program
    {

        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.Clear();

                Console.SetCursorPosition(30, 1);
                Console.Write("======================");
                Console.SetCursorPosition(33, 2);
                Console.Write("Menu Principal");
                Console.SetCursorPosition(30, 3);
                Console.Write("======================");
                Console.SetCursorPosition(30, 5);
                Console.Write("[1] Dia e Mes");
                Console.SetCursorPosition(30, 7);
                Console.Write("[2] Estados e Siglas");
                Console.SetCursorPosition(30, 9);
                Console.Write("[3] Número por Extenso");
                Console.SetCursorPosition(30, 11);
                Console.Write("[4] Finalizar");
                Console.SetCursorPosition(30, 13);
                Console.Write("Digite a sua opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            DiaMes();
                            break;
                        }
                    case 2:
                        {
                            Estado();
                            break;
                        }
                    case 3:
                        {
                            Extenso();
                            break;
                        }
                    case 4:
                        {
                            Finalizar();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.SetCursorPosition(25, 13);
                            Console.Write("[** Opção Inválida **]");
                            Console.ReadKey();
                            break;
                        }
                }



            } while (opc != 4);
        }
        static void DiaMes()
        {
            string vResp;

            do
            {
                Console.Clear();

                string[] dia = { "", "DOMINGO", "SEGUNDA", "TERCA", "QUARTA", "QUINTA", "SEXTA", "SABADO" };

                string[] mes = { "", "JANEIRO", "FEVEREIRO", "MARÇO", "ABRIL", "MAIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };

                string m, d;

                int a, b;

                Console.SetCursorPosition(30, 5);
                Console.Write("Deseja consultar um dia da semana? ");
                d = (Console.ReadLine());

                Console.SetCursorPosition(30, 7);
                Console.Write("Deseja consultar um mês? ");
                m = (Console.ReadLine());

                if (d == "Sim" || d == "sim" || d == "S" || d == "s")
                {
                    Console.SetCursorPosition(30, 9);
                    Console.Write("Qual dia deseja consultar (1 á 7)? ");
                    a = int.Parse(Console.ReadLine());

                    if (a <= 0 || a > 7)
                    {
                        Console.SetCursorPosition(30, 11);
                        Console.Write("Dia inválido");
                    }
                    else
                    {
                        Console.SetCursorPosition(30, 11);
                        Console.Write($"{dia[a]}");
                    }

                }

                if (m == "Sim" || m == "sim" || m == "S" || m == "s")
                {
                    Console.SetCursorPosition(30, 13);
                    Console.Write("Qual mês deseja consultar (1 á 12)? ");
                    b = int.Parse(Console.ReadLine());

                    if (b <= 0 || b > 12)
                    {
                        Console.SetCursorPosition(30, 15);
                        Console.Write("Mês inválido");
                    }
                    else
                    {
                        Console.SetCursorPosition(30, 15);
                        Console.Write($"{mes[b]}");
                    }
                }
                Console.SetCursorPosition(30, 18);
                Console.Write("Deseja voltar ao menu? ");
                vResp = Console.ReadLine();
            } while (vResp.ToLower() == "n" || vResp.ToLower() == "nao" || vResp.ToLower() == "não");
        }
        static void Estado()
        {
            string conta;
            
                do
                {
                    Console.Clear();
                    string[,] estado = new string[27, 2];
                    string texto;
                    bool achou;

                    estado[0, 0] = "SP"; estado[0, 1] = "São Paulo";
                    estado[1, 0] = "RJ"; estado[1, 1] = "Rio de Janeiro";
                    estado[2, 0] = "MG"; estado[2, 1] = "Minas Gerais";
                    estado[3, 0] = "PE"; estado[3, 1] = "Pernambuco";
                    estado[4, 0] = "ES"; estado[4, 1] = "Espirito Santo";
                    estado[5, 0] = "AC"; estado[5, 1] = "Acre";
                    estado[6, 0] = "AL"; estado[6, 1] = "Alagoas";
                    estado[7, 0] = "AP"; estado[7, 1] = "Amapá";
                    estado[8, 0] = "AM"; estado[8, 1] = "Amazonas";
                    estado[9, 0] = "BA"; estado[9, 1] = "Bahia";
                    estado[10, 0] = "CE"; estado[10, 1] = "Ceará";
                    estado[11, 0] = "DF"; estado[11, 1] = "Distrito Federal";
                    estado[12, 0] = "GO"; estado[12, 1] = "Goiás";
                    estado[13, 0] = "MA"; estado[13, 1] = "Maranhão";
                    estado[14, 0] = "MT"; estado[14, 1] = "Mato Grosso";
                    estado[15, 0] = "MS"; estado[15, 1] = "Mato Grosso do Sul";
                    estado[16, 0] = "PA"; estado[16, 1] = "Pará";
                    estado[17, 0] = "PB"; estado[17, 1] = "Paraíba";
                    estado[18, 0] = "PR"; estado[18, 1] = "Paraná";
                    estado[19, 0] = "PI"; estado[19, 1] = "Piauí";
                    estado[20, 0] = "RN"; estado[20, 1] = "Rio Grande do Norte";
                    estado[21, 0] = "RS"; estado[21, 1] = "Rio Grande do Sul";
                    estado[22, 0] = "RO"; estado[22, 1] = "Rondônia";
                    estado[23, 0] = "RR"; estado[23, 1] = "Roraima";
                    estado[24, 0] = "SC"; estado[24, 1] = "Santa Catarina";
                    estado[25, 0] = "SE"; estado[25, 1] = "Sergipe";
                    estado[26, 0] = "TO"; estado[26, 1] = "Tocantins";

                        achou = false;
                        Console.SetCursorPosition(30, 5);
                        Console.Write("Digite uma Sigla ou Estado (Em maiúsculo): ");
                        texto = (Console.ReadLine());

                    for (int i = 0; i < 27; i++)
                    {
                        if (texto == estado[i, 0])
                        {
                        Console.SetCursorPosition(30, 7);
                        Console.Write(texto + " corresponde a " + estado[i, 1]);
                            achou = true;
                            break;
                        }

                        else if (texto == estado[i, 1])
                        {
                            Console.SetCursorPosition(30, 7);
                            Console.Write(texto + " corresponde a " + estado[i, 0]);
                            achou = true;
                            break;

                        }
                    }
                        if (achou == false)
                        {
                            Console.SetCursorPosition(30, 7);
                            Console.Write("Sigla não cadastrada \n");      
                        }
                Console.SetCursorPosition(30, 9);
                Console.Write("Deseja voltar ao menu? ");
                conta = Console.ReadLine();
            } while (conta.ToLower() == "n");

        }
        static void Extenso()
        {
            string vResp;
           do
            {

                Console.Clear();

                string[] unidade = {"Zero","Um","Dois","Três","Quatro","Cinco","Seis","Sete","Oito","Nove","Dez","Onze","Doze","Treze","Quatorze","Quinze","Dezesseis",
            "Dezessete","Dezoito","Dezenove"};
                string[] dezena = { "", " ", "Vinte", "Trinta", "Quarenta", "Cinquenta", "Sessenta", "Setenta", "Oitenta", "Noventa" };
                string[] centena = { "", "Cento", "Duzentos", "Trezentos", "Quatrocentos", "Quinhentos", "Seiscentos", "Setecentos", "Oitocentos", "Novecentos" };
                int n, ne, nd, dd, ndd, ddd;

                Console.SetCursorPosition(30, 5);
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0 || n > 1000)
                {
                    Console.SetCursorPosition(30, 7);
                    Console.Write("Número Fora da Faixa");
                }
                else if (n < 20)
                {
                    Console.SetCursorPosition(30, 7);
                    Console.Write(unidade[n]);
                }
                else if (n < 100)
                {
                    ne = n / 10;
                    nd = n % 10;

                    Console.SetCursorPosition(30, 7);
                    Console.Write(dezena[ne]);
                    if (nd > 0)
                    {
                        Console.Write(" e " + unidade[nd]);
                    } 
                }
                else if (n == 100)
                {
                    Console.SetCursorPosition(30, 7);
                    Console.Write("Cem");
                }
                else if (n < 1000)
                {
                    ne = n / 100;
                    dd = n / 10;
                    ddd = dd % 10;
                    ndd = n % 10;
                    nd = n % 100;

                    Console.SetCursorPosition(30, 7);
                    Console.Write(centena[ne]);
                    if (nd < (20))
                    {
                        if (nd > (0))
                        {
                            Console.Write(" e " + unidade[nd]);
                        }
                    }
                    else if (ddd > (0))
                    {
                        Console.Write(" e " + dezena[ddd]);
                        if (ndd > (0))
                        {
                            Console.Write(" e " + unidade[ndd]);
                        }

                    }
                    else if (ndd > (0))
                    {
                        Console.Write(" e " + unidade[ndd]);
                    }
                }
                else if (n == 1000)
                {
                    Console.SetCursorPosition(30, 7);
                    Console.Write("Mil");
                }
                Console.SetCursorPosition(30, 10);
                Console.Write("Deseja voltar ao menu? (S/N) ");
                vResp = Console.ReadLine();
            } while (vResp.ToLower() == "n" || vResp.ToLower() == "nao" || vResp.ToLower() == "não");
        }
        static void Finalizar()
        {
            Console.Clear();

            Console.SetCursorPosition(29, 04);
            Console.Write("===================================");
            Console.SetCursorPosition(30, 06);
            Console.Write("Espero ter ajudado");
            Console.SetCursorPosition(30, 08);
            Console.Write("Obrigado por utilizar meu sistema");
            Console.SetCursorPosition(29, 10);
            Console.Write("===================================\n");
        }
    }
}
