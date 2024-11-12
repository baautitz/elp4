using System;

namespace ProjetoELP4.Models {
	internal class ColecaoCidades : Colecao<Cidades> {

		public Cidades PesquisarPorNome(string nome) {
			return aLista.Find(p => p.Cidade == nome);
		}

		public void Imprimir() {
			if (base.Tamanho() <= 0) {
				Console.WriteLine("Não há nehuma cidade na lista.");
				return;
			}

			Console.WriteLine($"Listando {base.Tamanho()} {(base.Tamanho() > 1 ? "países" : "país")}...");
			foreach (Cidades c in aLista) {
				Console.WriteLine($"Cidade: {c.Codigo} - {c.Cidade}");
				Console.WriteLine($"Estado: {c.OEstado.Estado}");
				Console.WriteLine($"DDD: {c.DDD}");
			}
		}

	}
}
