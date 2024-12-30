using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using trabalhoAAD.Models;

namespace trabalhoAAD.Services
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Atendente> Atendentes { get; set; }

        public virtual DbSet<Atendimento> Atendimentos { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public virtual DbSet<Fornecedor> Fornecedors { get; set; }

        public virtual DbSet<Marca> Marcas { get; set; }

        public virtual DbSet<Material> Materials { get; set; }

        public virtual DbSet<Mecanico> Mecanicos { get; set; }

        public virtual DbSet<Modelo> Modelos { get; set; }

        public virtual DbSet<Morada> Morada { get; set; }

        public virtual DbSet<Orcamento> Orcamentos { get; set; }

        public virtual DbSet<Pagamento> Pagamentos { get; set; }

        public virtual DbSet<Relatorio> Relatorios { get; set; }

        public virtual DbSet<Servico> Servicos { get; set; }

        public virtual DbSet<ServicoMaterial> ServicoMaterials { get; set; }

        public virtual DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Name=DefaultConnection");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //para criar as migrations do identity
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Atendente>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__atendent__3213E83FA8A520A8");

                entity.ToTable("atendente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.IdMorada).HasColumnName("id_morada");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.HasOne(d => d.IdMoradaNavigation).WithMany(p => p.Atendentes)
                    .HasForeignKey(d => d.IdMorada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Atendente_Morada");
            });

            modelBuilder.Entity<Atendimento>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__atendime__3213E83F17D305BE");

                entity.ToTable("atendimento");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Data).HasColumnName("data");
                entity.Property(e => e.IdAtendente).HasColumnName("id_atendente");
                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("motivo");

                entity.HasOne(d => d.IdAtendenteNavigation).WithMany(p => p.Atendimentos)
                    .HasForeignKey(d => d.IdAtendente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Atendimento_Atendente");

                entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Atendimentos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Atendimento_Cliente");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__cliente__3213E83FC787D08F");

                entity.ToTable("cliente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");
                entity.Property(e => e.IdMorada).HasColumnName("id_morada");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.Telefone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.IdMoradaNavigation).WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdMorada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Morada");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__forneced__3213E83FE5C44664");

                entity.ToTable("fornecedor");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.IdMorada).HasColumnName("id_morada");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.Telefone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.IdMoradaNavigation).WithMany(p => p.Fornecedors)
                    .HasForeignKey(d => d.IdMorada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fornecedor_Morada");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__marca__3213E83F2A79F4C7");

                entity.ToTable("marca");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__material__3213E83F4C64C0A1");

                entity.ToTable("material");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.IdFornecedor).HasColumnName("id_fornecedor");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdFornecedorNavigation).WithMany(p => p.Materials)
                    .HasForeignKey(d => d.IdFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Material_Fornecedor");
            });

            modelBuilder.Entity<Mecanico>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__mecanico__3213E83FF83DEFE3");

                entity.ToTable("mecanico");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Especialidade).HasColumnName("especialidade");
                entity.Property(e => e.IdMorada).HasColumnName("id_morada");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.Telefone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.IdMoradaNavigation).WithMany(p => p.Mecanicos)
                    .HasForeignKey(d => d.IdMorada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mecanico_Morada");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__modelo__3213E83F575CF627");

                entity.ToTable("modelo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.IdMarca).HasColumnName("id_marca");
                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nome");
                entity.Property(e => e.TipoCombustivel).HasColumnName("tipo_combustivel");

                entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Modelos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Modelo_Marca");
            });

            modelBuilder.Entity<Morada>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__morada__3213E83FB4A30983");

                entity.ToTable("morada");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Cp1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("cp1");
                entity.Property(e => e.Cp2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("cp2");
                entity.Property(e => e.Numero)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("numero");
            });

            modelBuilder.Entity<Orcamento>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__orcament__3213E83FC0BA61E7");

                entity.ToTable("orcamento");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.IdServico).HasColumnName("id_servico");
                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.HasOne(d => d.IdServicoNavigation).WithMany(p => p.Orcamentos)
                    .HasForeignKey(d => d.IdServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orcamento_Servico");
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__pagament__3213E83F8AC1A597");

                entity.ToTable("pagamento");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Data).HasColumnName("data");
                entity.Property(e => e.IdOrcamento).HasColumnName("id_orcamento");
                entity.Property(e => e.Metodo).HasColumnName("metodo");

                entity.HasOne(d => d.IdOrcamentoNavigation).WithMany(p => p.Pagamentos)
                    .HasForeignKey(d => d.IdOrcamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pagamento_Orcamento");
            });

            modelBuilder.Entity<Relatorio>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__relatori__3213E83F935DEFD9");

                entity.ToTable("relatorio");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Data).HasColumnName("data");
                entity.Property(e => e.IdServico).HasColumnName("id_servico");
                entity.Property(e => e.Texto)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("texto");
                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.IdServicoNavigation).WithMany(p => p.Relatorios)
                    .HasForeignKey(d => d.IdServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Relatorio_Servico");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__servico__3213E83F8B436043");

                entity.ToTable("servico");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.DataFim).HasColumnName("data_fim");
                entity.Property(e => e.DataInicio).HasColumnName("data_inicio");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.IdMecanico).HasColumnName("id_mecanico");
                entity.Property(e => e.IdVeiculo).HasColumnName("id_veiculo");
                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.HasOne(d => d.IdMecanicoNavigation).WithMany(p => p.Servicos)
                    .HasForeignKey(d => d.IdMecanico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servico_Mecanico");

                entity.HasOne(d => d.IdVeiculoNavigation).WithMany(p => p.Servicos)
                    .HasForeignKey(d => d.IdVeiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Servico_Veiculo");
            });

            modelBuilder.Entity<ServicoMaterial>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("servico_material");

                entity.Property(e => e.IdMaterial).HasColumnName("id_material");
                entity.Property(e => e.IdServico).HasColumnName("id_servico");
                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.HasOne(d => d.IdMaterialNavigation).WithMany()
                    .HasForeignKey(d => d.IdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicoMaterial_Material");

                entity.HasOne(d => d.IdServicoNavigation).WithMany()
                    .HasForeignKey(d => d.IdServico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicoMaterial_Servico");
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__veiculo__3213E83F2041EC44");

                entity.ToTable("veiculo");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
                entity.Property(e => e.Ano).HasColumnName("ano");
                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
                entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
                entity.Property(e => e.Matricula)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("matricula");
                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Veiculos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veiculo_Cliente");

                entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Veiculos)
                    .HasForeignKey(d => d.IdModelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veiculo_Modelo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
