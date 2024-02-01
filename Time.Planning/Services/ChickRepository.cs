using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time.Planning.Objects;

namespace Time.Planning.Services;

public class ChickRepository
{
    private readonly MyDb _myDb;
    public ChickRepository( MyDb myDb)
    {
        _myDb = myDb;
    }

    public List<Chick> GetAllChick()
    {
        return _myDb.Chicks.ToList();
    }
    public void SaveChick( Chick chick)
    {
        if( chick.Length.Hours == 0 && chick.Length.Minutes == 0)
        {

        }
        else
        {
            _myDb.Chicks.Add(chick);
            Save();
        }
    }
    public Chick GetChick(int id)
    {
        return _myDb.Chicks.FirstOrDefault(x => x.ChickId == id);
    }
    public void Save()
    {
        _myDb.SaveChanges();
    }
}
