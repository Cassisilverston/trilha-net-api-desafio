using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
 public class Tarefa
{
    public int Id { get; set; }
    public required string Titulo { get; set; } 
    public required string Descricao { get; set; } 
    public DateTime Data { get; set; }
    public EnumStatusTarefa Status { get; set; }
}
}