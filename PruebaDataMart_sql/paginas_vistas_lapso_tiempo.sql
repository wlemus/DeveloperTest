WITH CTE AS (
		SELECT id_usuario, marca_de_tiempo,
		LAG(marca_de_tiempo,1) OVER (PARTITION BY id_usuario ORDER BY marca_de_tiempo ASC) AS prev_marca_de_tiempo
		FROM trafico_sitio_web ),
	CTE2 AS (
		SELECT CTE.*, 
		ISNULL(DATEDIFF(SECOND, CTE.prev_marca_de_tiempo,CTE.marca_de_tiempo), 0) AS dif_seg_t 
		FROM CTE ),
	CTE2_1 AS ( 
		SELECT CTE2.*, 0 AS sum_seg_acumulado ,1 AS group_
		FROM CTE2 where CTE2.prev_marca_de_tiempo is null
		UNION ALL
		SELECT CTE2.*, 
		IIF(R.sum_seg_acumulado+CTE2.dif_seg_t >=60,0,R.sum_seg_acumulado+CTE2.dif_seg_t) as sum_seg_acumulado,
		IIF(R.sum_seg_acumulado+CTE2.dif_seg_t >=60,R.group_+1, R.group_) group_
		FROM CTE2 
			 INNER JOIN CTE2_1 AS R ON R.id_usuario = CTE2.id_usuario AND R.marca_de_tiempo = CTE2.prev_marca_de_tiempo),
	CTE3 AS (
		SELECT CTE2_1.*, 
		COUNT(*) OVER (PARTITION BY CTE2_1.id_usuario,group_ ) num_elements_in_group
		FROM CTE2_1 ),
	CTE4 AS (
		SELECT CTE3.*,
		FIRST_VALUE(CTE3.marca_de_tiempo) OVER (PARTITION BY CTE3.id_usuario ORDER BY CTE3.id_usuario) tiempo_inicial,
		LAST_VALUE(CTE3.marca_de_tiempo) OVER (PARTITION BY CTE3.id_usuario ORDER BY CTE3.id_usuario) tiempo_final
		FROM CTE3
		WHERE CTE3.num_elements_in_group >= 5 )

SELECT T1.id_usuario, T1.num_elements_in_group as num_paginas_vistas, tiempo_inicial, tiempo_final,
DATEDIFF(SECOND, tiempo_inicial ,tiempo_final) as lapso_tiempo_seg
FROM CTE4 T1
GROUP BY T1.id_usuario, T1.num_elements_in_group, tiempo_inicial, tiempo_final
 