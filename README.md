# wlemus-datamart

## [PYTHON](PruebaDataMart_py/)
* ### EJERCICIO 1 
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;merge_arrays  
	Función que acepta dos arrays ordenados de enteros como parámetros y devuelve un solo array ordenado que contiene todos los elementos de ambos
[Ver código fuente de la solución](PruebaDataMart_py/ordenamiento.py)

## [C#](PruebaDataMart_net/)
* ### EJERCICIO 2
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;find_median  - 
    Función que acepta un array de enteros como parámetro y devuelve la mediana del conjunto
[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/Median.cs), [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/MedianTest.cs)

* ### EJERCICIO 3
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;BinaryTree 
    Clase que implementa un árbol binario de búsqueda. La clase tiene métodos para insertar, buscar e imprime el árbol en orden ascendente (en consola)
[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/BinaryTree/), [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/BinaryTreeTest.cs)

#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Complejidad computacional
    InsertNode: La operación InsertNode tiene una complejidad computacional de tiempo de O(log n), donde "n" representa el número total de nodos en el árbol. Este rendimiento se debe a la división repetida (a la mitad) del conjunto de datos en la búsqueda del nodo padre, lo que garantiza una rápida convergencia hacia el nodo correcto.

    SearchNode: Al igual que InsertNode, la operación de búsqueda tiene una complejidad de O(log n), donde "n" representa el número máximo de nodos en el árbol. Esta eficiencia se debe a la división repetida del conjunto de datos, que se divide a la mitad en cada iteración, permitiendo una rápida localización del nodo deseado.

* ### EJERCICIO 4
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;isAnagram 
    Función llamada isAnagram que acepta dos cadenas de texto como parámetros y determina si son anagramas (es decir, si tienen exactamente las mismas letras, pero en diferente orden)
[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/Anagram.cs), [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/AnagramTest.cs)

* ### EJERCICIO 5
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;findCommonElements 
    Función llamada findCommonElements que acepta una lista de listas como parámetro y devuelve una lista con los elementos comunes a todas las sub-listas

[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/ListsUtils.cs), [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/FindCommonElementsTest.cs)

* ### EJERCICIO 6
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;mergesort
    Implementación para el algoritmo de ordenamiento mergesort
[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/ListsUtils.cs), [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/MergeSortTest.cs)

* ### EJERCICIO 7
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;remove_duplicates 
    Función que acepta una lista como parámetro y devuelva una nueva lista sin elementos duplicados
[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/ListsUtils.cs),[Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/RemoveDuplicatesTest.cs)

* ### EJERCICIO 8
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;BinarySearch
    Dada una lista de números en orden ascendente y un número objetivo, esta función recursiva encuentra si el número objetivo está en la lista utilizando una búsqueda binaria
[Ver código de la solución](PruebaDataMart_net/PruebaLibrary/ListsUtils.cs), [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/BinarySearchTest.cs)

## [SQL SERVER](PruebaDataMart_sql/)
* ### EJERCICIO 9
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ingreso promedio por usuario 
    Se desea calcular el ingreso promedio por usuario para cada mes del año 2022. se puede suponer que existe una tabla llamada 'ventas' con columnas para 'id_usuario', 'ingreso' y 'fecha'
[Ver código de la consulta SQL](PruebaDataMart_sql/ingreso_prom_usuario.sql)
* ### EJERCICIO 10
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Clientes que más dinero han gastado en el último año 
    Dada una tabla llamada 'pedidos_clientes' con columnas para 'id_pedido', 'id_cliente', 'fecha_pedido' y 'total_pedido', consulta que encuentra el top 10 de los clientes que más dinero han gastado en el último año
 [Ver código de la consulta SQL](PruebaDataMart_sql/top_clientes_%2Bgasto.sql)

* ### EJERCICIO 11
    Suponiendo que existe una tabla llamada 'trafico_sitio_web' con columnas para 'marca_de_tiempo' e 'id_usuario' este query identifica cualquier instancia en la que un usuario tenga más de 5 páginas vistas en un lapso de tiempo de 1 minuto.
 [Ver código de la consulta SQL](PruebaDataMart_sql/paginas_vistas_lapso_tiempo.sql)

 
* ### EJERCICIO 11
    Suponiendo que existe una tabla llamada 'trafico_sitio_web' con columnas para 'marca_de_tiempo' e 'id_usuario' este query identifica cualquier instancia en la que un usuario tenga más de 5 páginas vistas en un lapso de tiempo de 1 minuto.
 [Ver código de la consulta SQL](PruebaDataMart_sql/paginas_vistas_lapso_tiempo.sql)
 
 ## [MAS C#](PruebaDataMart_net/)
 * ### EJERCICIO 12
        Implemente un algoritmo que reciba en la entrada dos listas de números enteros y haga un map de cada elemento de la segunda lista con la función del problema 8 utilizando la primera lista como dominio de la búsqueda. Teniendo en cuenta que el tamaño de la primera lista podría ser muy grande explique qué beneficios tiene utilizar una búsqueda binaria en lugar de utilizar una búsqueda secuencial y cómo impacta la complejidad computacional de la solución. En circunstancias donde el segundo listado sea también grande es conveniente procesar las peticiones en paralelo; en este escenario sería conveniente poder configurar una máxima cantidad de workers para que procesen de forma paralela el segundo arreglo. Proponga una solución general a este problema utilizando C#.

   [Ver código de la solución](PruebaDataMart_net/PruebaLibrary/FindListsElements.cs),  [Ver código de las pruebas unitarias](PruebaDataMart_net/PruebaTest/SearchListElementsTest.cs)
    
#### &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Complejidad computacional

    La búsqueda secuencial tiene una complejidad computacional lineal O(n), donde “n” es la longitud de la lista más larga entre las dos. Esto se debe a que se necesita recorrer ambas listas para buscar el número objetivo, y el número máximo de comparaciones que se debe realizar sería proporcional a la longitud de la lista más larga.

    Por otro lado la búsqueda binaria tiene una complejidad computacional de O(log n) donde “n” es el número de elementos en la lista. En cada paso de la búsqueda binaria, se divide el conjunto de elementos en dos mitades y se descarta una de ellas en función de si el elemento deseado es mayor o menor que el elemento medio; lo anterior significa que, en cada iteración, la cantidad de elementos que quedan por buscar se reduce a la mitad (principal beneficio), lo que resulta en una reducción exponencial del espacio de búsqueda.

