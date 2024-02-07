SELECT TOP 10  pedidos.id_cliente,cli.nombre_cliente,sum(total_pedido) AS total_pedido FROM pedidos_clientes as pedidos
LEFT JOIN clientes cli ON cli.id_cliente = pedidos.id_cliente
WHERE pedidos.fecha_pedido >= DATEADD(YEAR, -1, GETDATE())
GROUP BY pedidos.id_cliente,cli.nombre_cliente
ORDER BY total_pedido DESC
