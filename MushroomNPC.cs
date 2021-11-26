using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MushroomNPC : MonoBehaviour
{
    
    private GameObject jugador;
    //public int vida;
    public string nombre;
    private string texto;
    private TextMeshPro interfazTexto;

    // Start is called before the first frame update
    void Start()
    {
        interfazTexto = transform.Find("Interfaz").Find("Info").Find("Texto").GetComponent<TextMeshPro>();
        transform.Find("Interfaz").Find("Info").Find("Titulo").GetComponent<TextMeshPro>().text = nombre;
        jugador = GameObject.FindGameObjectWithTag("Player");
        asignarTexto();

        interfazTexto.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(jugador)
        transform.LookAt(jugador.transform);
    }

    private void asignarTexto()
    {
        switch (nombre)
        {
            case "Carlets":
                texto = "Todo, todo es negocio";
                break;
            case "Peublau":
                texto = "Nuestra civilización montó un desafío mentiroso. Y así como vamos, no es posible para todos colmar ese sentido de despilfarro que se le ha dado a la vida";
                break;
            case "Turmes":
                texto = "El hombrecito promedio, a veces sueña con vacaciones y la libertad. Siempre sueña con concluir las cuentas, hasta que un día el corazón se para y adiós";
                break;
            case "Roviol":
                texto = "Arrasamos las selvas, las selvas verdaderas e implantamos selvas anónimas de cemento";
                break;
            case "Fredolics":
                texto = "Tenemos una civilización contra la sencillez, la sobriedad. Pero peor, contra la libertad que supone tener tiempo para vivir las relaciones humanas, lo único trascendente: amor, amistad, aventuras, solidaridad";
                break;
            case "Morenes":
                texto = "Prometemos una vida de derroche y despilfarro, que en el fondo constituye una cuenta regresiva contra la naturaleza y contra la humanidad como futuro";
                break;
            case "Apagallums":
                texto = "¡Tú siempre con tus “NO PUEDE HACERSE”! ¿Es que escuchándome no estabas?.";
                break;
            case "Poagre":
                texto = "Si aspiráramos en esta humanidad de consumo, son imprescindibles tres planetas para poder vivir";
                break;
            case "Llanegues":
                texto = "Hemos nacido sólo para consumir y consumir y cuando no podemos, cargamos con la frustración, la pobreza y hasta la automarginación y autoexclusión";
                break;
            case "Rossinyol":
                texto = "La economía sucia, el narcotráfico, la estafa, el fraude y la corrupción, son plagas contemporáneas cobijadas por ese antivalor, ese que sostiene que somos más felices si nos enriquecemos sea como sea";
                break;
            case "Rovell":
                texto = "Es posible un mundo con una humanidad mejor. Tal vez hoy la primera tarea sea salvar la vida";
                break;

            //Cambios de escena
            case "Ratolí":
                texto = "Pero bueno… ¿qué tal? soy el guardián de una mazmorra, <Golden Tower> por unas monedas de oro puedes intentar completarla, los adeptos se entrenan en estas zonas para conseguir ser más fuertes.";
                break;
            case "SoldadoCentinela":
                texto = "Saludos adepta, puedes acceder a la ciudad amurallada Al-baidá <La Blanca> pero no te metas en líos, respeta y te respetaran.";
                break;


            //Albaida Escena
            case "Petko":
                texto = "Hacía tanto tiempo que el portal no funcionaba que los habitantes de este lugar pensábamos que era una leyenda, bienvenida a la ciudad blanca.";
                break;

        }
    }

    private int letra = 0;
    public IEnumerator mostrarTextoAnimado()
    {
        
        if (letra < texto.Length)
        {
            interfazTexto.text+= texto[letra];
            yield return new WaitForSeconds(0.05f);
            letra++;
            StartCoroutine(mostrarTextoAnimado());
        }

        if (letra == texto.Length)
        {
            mostrado = true;
            letra = 0;
        }

            
    }

    private bool mostrado = false;
    public bool botonAceptar()
    {
        if (mostrado)
        {
            return true;
        }
        else if (letra < texto.Length)
        {
            letra = texto.Length;
            interfazTexto.text = texto;
            mostrado = true;
            //interfazTexto.text = "";
            //letra = 0;
            return false;
        }


        return true;

    }

    }
