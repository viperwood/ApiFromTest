using WebApplication1.Context;

namespace WebApplication1;

public class Helper
{
    static public readonly PostgresContext Database = new PostgresContext();
}