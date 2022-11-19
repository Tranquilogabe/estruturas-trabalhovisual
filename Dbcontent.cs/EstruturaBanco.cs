//Criacao do banco de dados local para os usuarios

    public class EstruturaBanco : Dbcontext
    {
             
             public EstruturaBanco (DbcontextOptions<EstruturaBanco> options) : 
             base (options)
             {
                public DbSet<UsuarioModel> Usuarios {get; set}
             }

    }


    // Em caso de uso de uma migration seria 
    // Add Migration *nome* -context EstruturaBanco