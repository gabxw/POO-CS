using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Aluno
    {
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        private double media;

        public Aluno(string nome, double nota1, double nota2){
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            MediaAluno();
            SituacaoAluno();
        }

        private string MediaAluno()
        {
            media = (Nota1 + Nota2) / 2;
            return $"A média do aluno é {media:F1}";
        }
        public void MostrarMedia()
        {
            Console.WriteLine(MediaAluno());
        }

        public void MostrarSituacao()
        {
            Console.WriteLine(SituacaoAluno());
        }

        private string SituacaoAluno()
        {
            if (media >= 6)
            {
                return $"O aluno passou";
            }
            else
            {
                return $"o aluno reprovou";
            }
            
        }
    }
}
