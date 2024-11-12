using System;

namespace ProjetoELP4.Models {
	internal class ColecaoEstados : Colecao<Estados> {

		public Estados PesquisarPorUF(string uf) {
			return aLista.Find(p => p.UF == uf);
		}

		public void Imprimir() {
			if (base.Tamanho() <= 0) {
				Console.WriteLine("Não há nehum estado na lista.");
				return;
			}

			Console.WriteLine($"Listando {base.Tamanho()} {(base.Tamanho() > 1 ? "países" : "país")}...");
			foreach (Estados e in aLista) {
				Console.WriteLine($"Estado: {e.Codigo} - {e.Estado}");
				Console.WriteLine($"UF: {e.UF}");
			}
		}

	}
}
