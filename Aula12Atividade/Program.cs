using Aula12Atividade;

Console.WriteLine("ShoppiMK\n\n");

produtos produto01 = new produtos();

produto01.nome = "Suco de Laranja";
produto01.descricao = "Sucos extraidos das laranjas mais puras e saborosas";
produto01.quantidade = 250;
produto01.preco = 7.50;
produto01.status = true;

produto01.mostra();

produtos produto02 = new produtos();

produto02.nome = "Suco de Morango";
produto02.descricao = "Morangos meticulosamente selecionados";
produto02.quantidade = 450;
produto02.preco = 8.50;
produto02.status = true;

produto02.mostra();

produtos produto03 = new produtos();

produto03.nome = "Suco de Maracuja";
produto03.descricao = "Maracujas ricos em proteinas e os melhores";
produto03.quantidade = 350;
produto03.preco = 7.50;
produto03.status = true;

produto03.mostra();



produto01.desativa();
produto02.desativa();

produto01.mostra();
produto02.mostra();
produto03.mostra();




Console.ReadKey();


