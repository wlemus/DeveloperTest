DECLARE @anio as int;
set @anio=2022

SELECT usu.nombre, usu.apellido,  DATEPART(MONTH,fecha)  as mes, FORMAT(AVG(ALL ingreso),'C') as ingreso_promedio
FROM [dbo].[ventas] ing
LEFT JOIN[dbo].[usuarios] usu on ing.id_usuario= usu.id_usuario
WHERE DATEPART(YEAR,fecha) = @anio
group by ing.id_usuario, DATEPART(MONTH,fecha), usu.nombre, usu.apellido
order by ing.id_usuario, mes