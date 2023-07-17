using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* El atributo `[CreateAssetMenu(fileName="NuevoPersonaje",menuName="Personaje")]` se utiliza para crear
un elemento de menú personalizado en el Editor de Unity. Te permite crear una nueva instancia de los `Personajes`
objeto programable directamente desde el menú "Activos" del Editor de Unity. El parámetro `fileName` especifica
el nombre predeterminado para el archivo de activos creado, y el parámetro `menuName` especifica la ruta en el
Menú "Activos" donde se ubicará el elemento de menú personalizado. */
[CreateAssetMenu(fileName="NuevoPersonaje",menuName="Personaje")]
/* La clase "Personajes" es un objeto programable que contiene información sobre un personaje jugable,
incluyendo el objeto del juego del personaje, la imagen del sprite y el nombre. */
public class Personajes : ScriptableObject
{
    public GameObject personajeJugable;
    public Sprite imagen;
    public string nombre;
}
