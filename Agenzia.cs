using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Esercizio 2: Agenzia immobiliare

Si vuole progettare un’applicazione in grado di gestire un’agenzia 
immobiliare. 

Gli immobili sono caratterizzati da:
- un codice alfanumerico, 
- indirizzo, 
- cap, 
- città 
- una superficie espressa in mq attraverso un numero intero. 


L’agenzia gestisce diverse tipologie di immobili: 
- Box, 
- Appartamenti 
- Ville.

Per i box è riportato il numero di posti auto. 
Per gli appartamenti è 
riportato in numero di vani e il numero di bagni.

Per le ville è previsto, 
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire 
una descrizione completa dell'immobile. StampaSchedaImmobile

Provare a pensare ad una funzione di ricerca.

*/

namespace csharp_agenzia
{
    public class Agenzia
    {
        private string sNome;
        public string Nome
        { get { return sNome; } set { sNome = value; } }    
        public List<Immobile> Immobili { get; set; }
        public Agenzia(string sNome)
        {
            this.Nome = sNome;
            Immobili = new List<Immobile>();
        }

        
        public void AddImmobile(Immobile i)
        {
            Immobili.Add(i);
        }

        internal void AddListaImmobili(List<Immobile> immobiles)
        {
           foreach (Immobile im in immobiles)
                AddImmobile(im);
        }

        public List<Immobile> Searchimmobili(string key)
        {
            /*List<Immobile> miaSottoLista = new List<Immobile> ();
            foreach (Immobile imm in Immobili)
            {
                if (imm.Contains(key))
                    miaSottoLista.Add(imm);
            }
            return miaSottoLista;*/
            return this.Immobili.FindAll(i => i.Contains(key));
        }
    }
}
