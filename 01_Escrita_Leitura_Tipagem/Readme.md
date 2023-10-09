C# é uma linguagem fortemente tipada. Todas as variáveis e constantes têm um tipo, assim como cada expressão que é avaliada como um valor. Cada declaração de método especifica um nome, o tipo e a variante (valor, referência ou saída) de cada parâmetro de entrada e do valor retornado. A biblioteca de classes do .NET define tipos numéricos internos e tipos complexos que representam uma grande variedade de constructos. Isso inclui o sistema de arquivos, conexões de rede, coleções e matrizes de objetos e datas. Um programa em C# típico usa tipos da biblioteca de classes e tipos definidos pelo usuário que modelam os conceitos que são específicos para o domínio do problema do programa.

As informações armazenadas em um tipo podem incluir os seguintes itens:

O espaço de armazenamento que uma variável do tipo requer.
Os valores mínimo e máximo que ele pode representar.
Os membros (métodos, campos, eventos e etc.) que ele contém.
O tipo base do qual ele herda.
A interface implementada.
Os tipos de operações que são permitidos.
O compilador usa as informações de tipo para garantir que todas as operações que são realizadas em seu código sejam fortemente tipadas. Por exemplo, se você declarar uma variável do tipo int, o compilador permitirá que você use a variável nas operações de adição e subtração. Se você tentar executar as mesmas operações em uma variável do tipo bool, o compilador gerará um erro, como mostrado no exemplo a seguir:
