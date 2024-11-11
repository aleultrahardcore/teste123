<?php
// Pergunta: Crie uma classe Cliente com as propriedades nome, email, telefone e um método exibirInformacoes.
class Cliente {
    public $nome;
    public $email;
    public $telefone;

    // Construtor para inicializar as propriedades da classe
    public function __construct($nome, $email, $telefone) {
        $this->nome = $nome;
        $this->email = $email;
        $this->telefone = $telefone;
    }

    // Método para exibir as informações do cliente
    public function exibirInformacoes() {
        return "Cliente: {$this->nome}, Email: {$this->email}, Telefone: {$this->telefone}";
    }
}

// Criando uma instância da classe Cliente e preenchendo os dados
$cliente = new Cliente("João Silva", "joao@email.com", "1234-5678");

// Exibindo as informações do cliente
echo 'parte clientes: <br>';
echo $cliente->exibirInformacoes();

///------- parte banco --------

// Pergunta: Conecte-se ao banco de dados 'loja'
// $servername = "localhost";
// $username = "root";
// $password = "";
// $dbname = "loja";

// // Criando a conexão com MySQL
// $conn = new mysqli($servername, $username, $password, $dbname);

// // Verificando se a conexão falhou
// if ($conn->connect_error) {
//     die("Conexão falhou: " . $conn->connect_error);
// }
// echo "Conexão bem-sucedida!";

//---------- parte inserção -------


// Pergunta: Insira registros na tabela 'clientes'
// $sql = "INSERT INTO clientes (nome, email, telefone) VALUES ('João Silva', 'joao@email.com', '1234-5678')";
// if ($conn->query($sql) === TRUE) {
//     echo "Novo registro inserido com sucesso!";
// } else {
//     echo "Erro: " . $sql . "<br>" . $conn->error;
// }

// // Pergunta: Exiba todos os registros da tabela 'clientes'
// $sql = "SELECT id, nome, email, telefone FROM clientes";
// $result = $conn->query($sql);

// if ($result->num_rows > 0) {
//     // Exibindo os dados em uma lista HTML
//     echo "<ul>";
//     while($row = $result->fetch_assoc()) {
//         echo "<li>ID: " . $row["id"]. " - Nome: " . $row["nome"]. " - Email: " . $row["email"]. " - Telefone: " . $row["telefone"]. "</li>";
//     }
//     echo "</ul>";
// } else {
//     echo "0 resultados";
// }

// $conn->close();

//---------- parte sql -------

// -- Pergunta: Selecione todos os clientes cujo nome começa com "M"
// SELECT * FROM clientes WHERE nome LIKE 'M%';

// -- Pergunta: Atualize o email de um cliente específico
// UPDATE clientes SET email = 'novoemail@email.com' WHERE id = 1;

// -- Pergunta: Exclua um cliente pelo ID
// DELETE FROM clientes WHERE id = 3;

// -- Pergunta: Ordene os clientes em ordem alfabética pelo nome
// SELECT * FROM clientes ORDER BY nome ASC;


// -- Pergunta: Calcule a soma de todos os valor_total dos pedidos
// SELECT SUM(valor_total) FROM pedidos;

// -- Pergunta: Retorne a média de valor_total dos pedidos
// SELECT AVG(valor_total) FROM pedidos;

// -- Pergunta: Conte quantos pedidos foram feitos por um cliente específico
// SELECT COUNT(*) FROM pedidos WHERE cliente_id = 1;

?>
