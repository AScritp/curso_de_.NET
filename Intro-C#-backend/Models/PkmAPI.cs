using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Intro_C__backend.Models
{
    // Esta clase representa la estructura de la respuesta de la PokeAPI para un Pokémon específico con los datos principales.
    // Incluye propiedades como habilidades, experiencia base, formas y índices de juego, son 3 list y un integer.
    public class PkmAPI
    {
        // Propiedad que representa un elemento lista de habilidades del Pokémon.
        [JsonPropertyName("abilities")]
        public List<AbilityWrapper> Abilities { get; set; }
        // Propiedad que representa un elemento integer de experiencia base del Pokémon.
        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        // Propiedad que representa un elemento lista de formas del Pokémon.
        [JsonPropertyName("forms")]
        public List<NamedAPIResource> Forms { get; set; }

        // Propiedad que representa un elemento lista de índices de juego del Pokémon.
        [JsonPropertyName("game_indices")]
        public List<GameIndex> GameIndices { get; set; }
    }

    // Esta clase representa un envoltorio para las habilidades del Pokémon, incluyendo si es una habilidad oculta y el slot en el que se encuentra.
    public class AbilityWrapper
    {
        [JsonPropertyName("ability")]
        public NamedAPIResource Ability { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("slot")]
        public int Slot { get; set; }
    }
    //  Esta clase representa un envoltorio para las formas del Pokémon, incluyendo el nombre y la URL de la forma.
    public class NamedAPIResource
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
    // Esta clase representa un índice de juego del Pokémon, incluyendo el índice del juego y la versión del juego.
    public class GameIndex
    {
        [JsonPropertyName("game_index")]
        public int Index { get; set; }

        [JsonPropertyName("version")]
        public NamedAPIResource Version { get; set; }
    }
}
