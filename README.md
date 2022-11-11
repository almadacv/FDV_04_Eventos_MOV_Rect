# Eventos y Movimiento Rectilíneo

El __jugador__ (paralelepípedo morado) se mueve usando los _eje_  y el método _Slerp de Quaternion_ para __suavizar__ los movimientos.

Tenemos 2 textos en la esquina superior derecha, que contienen _información sobre la salud del jugador y su puntuación_.
En la esquina inferior izquierda tenemos un _botón que alterna la velocidad del jugador entre normal y Turbo_, alternando también el color y el texto que se muestra.

En la escena tenemos cilindros que al tocar al jugador _reducen su salud_, actualizando el texto que contiene información sobre la salud del jugador.
Del mismo modo, disponemos de cilindros que al contactar con el jugador _aumentan su puntuación_ y actualizan la información sobre su puntuación.

Tenemos un cilindro verde, que conduce al cubo naranja que encuentra en medio de la escena, mientras que la esfera roja _sigue el movimiento_ del jugador, ambos contienen una _referencia al GameOject que tiene que seguir y actualizan su posición según el referencia_.
Cuando el jugador entra en contacto con el cubo naranja, _se desencadena un evento_ que, al _ser capturado por los objetos que están suscritos al evento_, se les aplica una fuerza.

Disponemos de dos cápsulas que _teletransportan cualquier objeto_ que entre en contacto con ellas. Cada cápsula _contiene una referencia a la otra_, y para evitar duplicar el objeto que entra en contacto con la cápsula, tenemos una variable booleana `bool isJiterring = false`; que se actualiza de acuerdo con el siguiente código:

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

![Eventos y Movimiento rectilíneo.](https://github.com/almadacv/fdv_04/blob/master/Gif/Events.gif)

