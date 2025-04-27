// See https://aka.ms/new-console-template for more information
using app_mediatr.DTOs;
using app_mediatr.Entities;
using app_mediatr.Repositorys;

Console.WriteLine("-------------- EXPLICITY OPERATOR: --------------");
Console.WriteLine("Simulando uma chamada para repositório de Clientes... \n");

var clienteRepository = new ClienteRepository();
Cliente clienteEntidade = clienteRepository.Get();

Console.WriteLine($"Cliente Entidade:");
Console.WriteLine($"Cliente Id: {clienteEntidade.Id}");
Console.WriteLine($"Cliente Nome: {clienteEntidade.Nome}\n");
Console.WriteLine("Convertendo cliente entidade para cliente DTO... \n");

ClienteDTO clienteDTO = (ClienteDTO)clienteEntidade; // -->> Necessário CAST Explicito para conversão funcionar

Console.WriteLine($"Cliente DTO:");
Console.WriteLine($"Cliente Id: {clienteDTO.Id}");
Console.WriteLine($"Cliente Nome: {clienteDTO.Nome}\n\n");

Console.WriteLine("-------------- IMPLICITY OPERATOR: --------------");
Console.WriteLine("Simulando uma chamada para repositório de Produtos... \n");

var produtoRepository = new ProdutoRepository();
Produto produtoEntidade = produtoRepository.Get();

Console.WriteLine($"Produto Entidade:");
Console.WriteLine($"Produto Id: {produtoEntidade.Id}");
Console.WriteLine($"Produto Descrição: {produtoEntidade.Descricao}\n");
Console.WriteLine("Convertendo produto entidade para produto DTO... \n");

ProdutoDTO produtoDTO = produtoEntidade; // -->> Não é necessário CAST Explicito

Console.WriteLine($"Produto DTO:");
Console.WriteLine($"Produto Id: {produtoDTO.Id}");
Console.WriteLine($"Produto Descirção: {produtoDTO.Descricao}");
