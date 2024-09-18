using System;

namespace ProjetoELP4.Models {
	internal class ColecoesPaises : Colecoes<Paises> {

		public Paises PesquisarPorSigla(string sigla) {
			return aLista.Find(p => p.Sigla == sigla);
		}

		public void Imprimir() {
			if (base.Tamanho() <= 0) {
				Console.WriteLine("Não há nehum pais na lista.");
				return;
			}

			Console.WriteLine($"Listando {base.Tamanho()} {(base.Tamanho() > 1 ? "países" : "país")}...");
			foreach (Paises p in aLista) {
				Console.WriteLine($"País: {p.Codigo} - {p.Pais}");
				Console.WriteLine($"Sigla: {p.Sigla}");
				Console.WriteLine($"DDI: {p.DDI}");
				Console.WriteLine($"Moeda: {p.Moeda}\n");
			}
		}

	}
}
