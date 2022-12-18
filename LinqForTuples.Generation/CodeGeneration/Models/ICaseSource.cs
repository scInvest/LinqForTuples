using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.Models
{
    public interface ICaseSource
    {
        string Name { get; }
        string InputPath { get; }
        string OutputPath { get; set; }
        (string Begin, string End) BlobMark { get; set; }
    }
}
