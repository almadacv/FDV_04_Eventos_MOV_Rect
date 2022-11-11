# Eventos y Movimiento Rectilíneo

Crear un script para mover al objeto jugador con los ejes Horizontal y Vertical
Implementar una UI que permita configurar con qué velocidad te moverás: turbo o normal. También debe mostar la cantidad de objetos recolectados y si chocas con alguno especial restar fuerza.
Agregar a tu escena un objeto que al ser recolectado por el jugador haga que otro objetos obstáculos se desplacen de su trayectoria.
Agrega un objeto que te teletransporte a otra zona de la escena.
Agrega un personaje que se dirija hacia un objetivo estático en la escena.
 Agrega un personaje que siga el movimiento del jugador

O player (parallelepipedo roxo) é movimentado fazendo uso dos eixos e o metdodo Slerp de Quaternion para suavizar os movimentos.

Temos 2 textos no canto superior direito, contento informaçoes sobre a saude do jugador e a sua pontuaçao.
No canto inferior esquerdo temos um botao que alterna a velocidade do jugador entre normal e Turbo, alternando tambem e a cor e o texto mostrado.

Na cena, temos cilindros que ao tocarem no jugador reduzem a sua saude, atualizando o texto que contem as informaçoes sobre a saude do jugador.
De mesmo modo, temos cilindros que ao entrar em contacto com o jugador, aumentam a sua pontuaçao e atualiza a informaçao sobre a pontuaçao do mesmo.

Temos um cilindro verde, que dirige ao cubo laranja que encontra no meio da cena, enquanto a esfera vermelha segue o movimento do jugador, ambos contendo uma referencia ao GameOject que tem que seguir e atualizando a sua posiçao de acordo com a referencia.
O jugador ao entrar em contacto com o cubo laranja, dispara um evento que ao ser captado pelos objectos que estao subscritos ao evento, e aplicado uma força sobre os mesmo.

Temos duas capsulas que teletransportam qualquer objecto que entre em contacto com eles. Cada capsula contem referencia sobre o outro, e para evitar que duplique o objecto que entre em contacto com a capsula, temos uma variavel boolena  bool isJiterring = false; que é atualizado de acordo com o codigo abaixo:

```C#
 public GameObject Teleport1;
    bool isJiterring = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isJiterring)
        {
            Teleport1.GetComponent<Teleport>().isJiterring = true;
            other.transform.position = Teleport1.transform.position;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isJiterring = false;
    }
```

![Eventos y Movimiento rectilíneo.](https://github.com/almadacv/EventosMovimientoRectilíneo/blob/main/Gif/Events.gif)
