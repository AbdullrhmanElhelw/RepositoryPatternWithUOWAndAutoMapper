using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;

public class AuthorReadDTO
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
}
