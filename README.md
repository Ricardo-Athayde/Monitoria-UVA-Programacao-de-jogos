# Monitoria UVA - Programacao de jogos
Aqui você vai encontrar pequenos projetos feitos na Unity com objetivo de ajudar os alunos da Universidade Veiga de Almeida nas aulas de Programação de jogos.

## Space Shooter
**Um Timelapse da criação do projeto será disponibilizado no youtube em algum momento.**

Jogo de nave espacial onde o objetivo é desviar dos asteroides que aparecem aleatoriamente no topo da tela. O projeto foi feito visando o fácil entendimento e aprendizado. Existem maneiras melhores de se chegar ao mesmo resultado.

Nesse projeto você encontra muitos conceitos básicos da Unity como:
- Movimentação de objetos por script (MoveBackground, Asteroid, Player)
- Sistema de Input (Player)
- Colocar prefabs em cena (SpawnAsteroids)
- Remover objetos de cena (Asteroid)
- Deteção de colisoes (Player)
- Manipulação de elementos de UI (HUD)
- Troca de cenas (MainMenu, DeadHUD)
- Encontrar referencias a componentes nos objetos (Player)

**Start Point**

Arquivos iniciais para criação do jogo. Utilizei [essas](https://assetstore.unity.com/packages/2d/environments/2d-space-kit-27662) artes encontradas na [Unity Asset Store](https://assetstore.unity.com/).

**Vesrion 1.0**

Primeira versão do jogo:
- Nave se movendo com os comandos do jogador
- Asteroides sendo criados aleatoriamente no topo da tela
- Asteroides se movendo e colidindo com a nave
- Background e Foreground Animados
- Sistema de Vida e Score
- Telas de Menu e Morte

**Desafio**

Criar misseis que podem ser atirados pelo jogador para destruir os asteroides. Todas as funções da Unity para fazer isso acontecer já foram usadas no projeto.

<details>
  <summary>Dicas:</summary>
  
- Criar Prefab do míssil (igual feito com o asteroide)

- Mover o míssil para cima (igual feito com os asteroides)

- Receber imput do jogador quendo ele aperta uma tecla (igual feito no Player)

- Colocar o míssil em jogo na posicao desejada (igual feito com os asteroides)

- Detectar a colisão do asteroide com o míssil (igual feito entre os asteroides e o Player)

- Destruir o asteroide e o míssil (igual feito com o asteroide)

  </details>
  
**Uso do atributo [SerializeField]**

Vocês podem observar o uso do atributo [SerializeField] antes da declaração de algumas variáveis. Isso é feito para que a Unity possa mostrar e controlar aquela variável através do Inspector sem que ela seja declarada como publica. Essa é a maneira correta de se trabalhar na Unity. Sei que isso é um pouco mais avançado, mas é bem comum as pessoas que aprendem Unity tenham a prática de colocar todas as variáveis como publicas sem necessidade. Essa é uma prática ruim e bem difícil de se livrar (acreditem em mim, passei por isso).

Vocês vão perceber também na declaração dessas variáveis a atribuição do valor default para elas. Isso não é obrigatório, mas como o compilador não entende que essa variável sera modificada dentro da Unity, ele fica dando um aviso que a variável nunca foi declarada. Isso remove esse aviso atribuindo o valor padrão do tipo da variável. Ex: Int = 0 , Bool = false, String = ""


