using System.Collections.Generic;
using Ulbraflix.domain.entities;

namespace Ulbraflix.domain.DTOs_e_VOs;

public record SerieRecord(
    int Id,
    string Name,
    string Sinopsis,
    bool IsWatched,
    List<Category> Categories,
    Rating Rating,
    List<Season> Seasons);