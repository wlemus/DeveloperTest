using PruebaDataMart_net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PruebaLibrary
{
    public class SearchListsElements
    {
        private int NumElementsReqParallelism;
        private int MaxNumWorkers;
        public SearchListsElements(int numElementsReqParallelism, int maxNumWorkers)
        {
            NumElementsReqParallelism = numElementsReqParallelism;
            MaxNumWorkers = maxNumWorkers;
        }
        public bool FindListsElements(List<int> Domainlist, List<int> ElementsList)
        {
            bool result = false;
            if (Domainlist == null || ElementsList == null)
                throw new ArgumentNullException();
            if (Domainlist.Count == 0)
                return false;

            //evaluate if parallelism is requiered
            if (ElementsList.Count < NumElementsReqParallelism)
                result = ProcessFindListsElementsSimple(Domainlist, ElementsList);
            else
                result = ProcessFindListsElementsWithParllelism(Domainlist, ElementsList);

            return result;
        }
        /// <summary>
        /// Process Find Lists Elements Simple
        /// </summary>
        /// <param name="Domainlist"></param>
        /// <param name="ElementsList"></param>
        /// <returns></returns>
        private bool ProcessFindListsElementsSimple(List<int> Domainlist, List<int> ElementsList)
        {
            foreach (int element in ElementsList)
            {
                if (ListsUtils.ExistsValueByBinarySearch(Domainlist, element))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Process Find Lists Elements With Parllelism
        /// </summary>
        /// <param name="Domainlist"></param>
        /// <param name="ElementsList"></param>
        /// <returns></returns>
        private bool ProcessFindListsElementsWithParllelism(List<int> Domainlist, List<int> ElementsList)
        {
            // Procesar los datos en paralelo 
           return ProcessInParallel(Domainlist, ElementsList);

        }

        private bool ProcessInParallel(List<int> Domainlist, List<int> ElementsList)
        {
            bool result = false;
            // Configuración de opciones para el paralelismo con el número máximo de trabajadores especificado
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            ParallelOptions options = new ParallelOptions
            {
                MaxDegreeOfParallelism = MaxNumWorkers, // Establecer el número máximo de trabajadores
                CancellationToken = cancellationTokenSource.Token
            };

            // Procesar los datos en paralelo
            Parallel.ForEach(ElementsList, options, (item, ParallelLoopState) =>
                {
                    result = ListsUtils.ExistsValueByBinarySearch(Domainlist, item);
                    if (result)
                    {
                       // cancellationTokenSource.Cancel();
                        ParallelLoopState.Stop();
                    }
                    // Aquí va el código que procesa cada elemento de la lista de forma paralela
                  
                });

            return result;
        }
    }
}
