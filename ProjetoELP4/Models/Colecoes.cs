using System.Collections.Generic;

namespace ProjetoELP4.Models {
	internal class Colecoes<T> where T : Pai {

		protected List<T> aLista;

		public Colecoes() {
			aLista = new List<T>();
		}

		public virtual void Inserir(T obj) {
			if (Pesquisar(obj.Codigo) != -1) return;

			aLista.Add(obj);
		}

		public virtual int Pesquisar(int codigo) {
			return aLista.FindIndex(o => o.Codigo == codigo);
		}

		public virtual bool Remover(T obj) { 
			aLista.Remove(obj);

			return true;
		}

		public int Tamanho() {
			return aLista.Count;
		}

	}
}
