Descrição
API para um sistema Gerenciador de tarefas.
O sistema deve permitir que o usuário crie, visualize, edite e exclua uma tarefa.

Requisitos: Arquitetura em Camadas

Uma tarefa deverá ter os seguintes campos:

- Um id único pra identificar cada tarefa;
- Um nome;
- Uma descrição sobre o que é a tarefa em si;
- Uma prioridade;
*Você pode definir se tem prioridade* `alta`, `média` *ou* `baixa`*, por exemplo;*
- Uma data limite para tarefa ser realizada;
- Um status.
*Você pode definir três status:* `concluída`*,* `em andamento` *e* `aguardando`*, por exemplo.*

EndPoints necessários
- Deve ser possível criar uma tarefa;
- Deve ser possível visualizar todas as tarefas criadas;
- Deve ser possível visualizar uma tarefa buscando pelo seu id;
- Deve ser possível editar informações de uma tarefa;
- Deve ser possível excluir uma tarefa.
