using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistence
{
    public partial class ContextDB : DbContext
    {
        public ContextDB()
        {
        }

        public ContextDB(DbContextOptions<ContextDB> options)
            : base(options)
        {
        }

        public virtual DbSet<ArquivoMensalNfe> ArquivoMensalNfe { get; set; }
        public virtual DbSet<Associado> Associado { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<CompraProduto> CompraProduto { get; set; }
        public virtual DbSet<Conta> Conta { get; set; }
        public virtual DbSet<ContaBanco> ContaBanco { get; set; }
        public virtual DbSet<Fornecedor> Fornecedor { get; set; }
        public virtual DbSet<GrupoProduto> GrupoProduto { get; set; }
        public virtual DbSet<MovimentacaoBancaria> MovimentacaoBancaria { get; set; }
        public virtual DbSet<Parceria> Parceria { get; set; }
        public virtual DbSet<PlanoConta> PlanoConta { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Rede> Rede { get; set; }
        public virtual DbSet<RedeAssociado> RedeAssociado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArquivoMensalNfe>(entity =>
            {
                entity.HasKey(e => e.IdArquivoMensalNfe);

                entity.ToTable("ArquivoMensalNFE", "RedeLojas");

                entity.HasIndex(e => e.IdAssociado)
                    .HasName("fk_ArquivoMensalNFE_Associado1_idx");

                entity.Property(e => e.IdArquivoMensalNfe)
                    .HasColumnName("idArquivoMensalNFE")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ano)
                    .HasColumnName("ano")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Arquivo)
                    .HasColumnName("arquivo")
                    .HasColumnType("blob");

                entity.Property(e => e.IdAssociado)
                    .HasColumnName("idAssociado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mes)
                    .HasColumnName("mes")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Situacao)
                    .IsRequired()
                    .HasColumnName("situacao")
                    .HasColumnType("enum('AGUARDANDO ENVIO','ENVIADO','PROCESSADO')")
                    .HasDefaultValueSql("AGUARDANDO ENVIO");

                entity.HasOne(d => d.IdAssociadoNavigation)
                    .WithMany(p => p.ArquivoMensalNfe)
                    .HasForeignKey(d => d.IdAssociado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ArquivoMensalNFE_Associado1");
            });

            modelBuilder.Entity<Associado>(entity =>
            {
                entity.HasKey(e => e.IdAssociado);

                entity.ToTable("Associado", "RedeLojas");

                entity.HasIndex(e => e.IdCidade)
                    .HasName("fk_Associado_Cidade1_idx");

                entity.Property(e => e.IdAssociado)
                    .HasColumnName("idAssociado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bairro)
                    .HasColumnName("bairro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .HasColumnName("cep")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasColumnName("complemento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fone1)
                    .IsRequired()
                    .HasColumnName("fone1")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Fone2)
                    .HasColumnName("fone2")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IdCidade)
                    .HasColumnName("idCidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rua)
                    .HasColumnName("rua")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Situcao)
                    .IsRequired()
                    .HasColumnName("situcao")
                    .HasColumnType("enum('ATIVO','INATIVO','BLOQUEADO')")
                    .HasDefaultValueSql("INATIVO");

                entity.HasOne(d => d.IdCidadeNavigation)
                    .WithMany(p => p.Associado)
                    .HasForeignKey(d => d.IdCidade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Associado_Cidade1");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.IdBanco);

                entity.ToTable("Banco", "RedeLojas");

                entity.Property(e => e.IdBanco)
                    .HasColumnName("idBanco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cidade>(entity =>
            {
                entity.HasKey(e => e.IdCidade);

                entity.ToTable("Cidade", "RedeLojas");

                entity.Property(e => e.IdCidade)
                    .HasColumnName("idCidade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("SE");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra);

                entity.ToTable("Compra", "RedeLojas");

                entity.HasIndex(e => e.IdAssociado)
                    .HasName("fk_Compra_Associado1_idx");

                entity.HasIndex(e => e.IdFornecedor)
                    .HasName("fk_Compra_Fornecedor1_idx");

                entity.Property(e => e.IdCompra)
                    .HasColumnName("idCompra")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataCompra).HasColumnName("dataCompra");

                entity.Property(e => e.IdAssociado)
                    .HasColumnName("idAssociado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFornecedor)
                    .HasColumnName("idFornecedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valorTotal")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdAssociadoNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.IdAssociado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Associado1");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.IdFornecedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Fornecedor1");
            });

            modelBuilder.Entity<CompraProduto>(entity =>
            {
                entity.HasKey(e => new { e.IdCompra, e.IdProduto });

                entity.ToTable("Compra_Produto", "RedeLojas");

                entity.HasIndex(e => e.IdCompra)
                    .HasName("fk_Compra_Produto_Compra1_idx");

                entity.HasIndex(e => e.IdProduto)
                    .HasName("fk_Compra_Produto_Produto1_idx");

                entity.Property(e => e.IdCompra)
                    .HasColumnName("idCompra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProduto)
                    .HasColumnName("idProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantidade)
                    .HasColumnName("quantidade")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnName("valorUnitario")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.CompraProduto)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Produto_Compra1");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.CompraProduto)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Compra_Produto_Produto1");
            });

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.HasKey(e => e.IdConta);

                entity.ToTable("Conta", "RedeLojas");

                entity.HasIndex(e => e.IdAssociado)
                    .HasName("fk_Conta_Associado1_idx");

                entity.HasIndex(e => e.IdFornecedor)
                    .HasName("fk_Conta_Fornecedor1_idx");

                entity.HasIndex(e => e.IdPlanoConta)
                    .HasName("fk_Conta_PlanoConta1_idx");

                entity.HasIndex(e => e.IdRede)
                    .HasName("fk_Conta_Rede1_idx");

                entity.Property(e => e.IdConta)
                    .HasColumnName("idConta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataPagamento).HasColumnName("dataPagamento");

                entity.Property(e => e.DataVencimento).HasColumnName("dataVencimento");

                entity.Property(e => e.IdAssociado)
                    .HasColumnName("idAssociado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFornecedor)
                    .HasColumnName("idFornecedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPlanoConta)
                    .HasColumnName("idPlanoConta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRede)
                    .HasColumnName("idRede")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JurosDesconto)
                    .HasColumnName("jurosDesconto")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Situacao)
                    .IsRequired()
                    .HasColumnName("situacao")
                    .HasColumnType("enum('ABERTA','QUITADA')");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ValorPago)
                    .HasColumnName("valorPago")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdAssociadoNavigation)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.IdAssociado)
                    .HasConstraintName("fk_Conta_Associado1");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("fk_Conta_Fornecedor1");

                entity.HasOne(d => d.IdPlanoContaNavigation)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.IdPlanoConta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conta_PlanoConta1");

                entity.HasOne(d => d.IdRedeNavigation)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.IdRede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Conta_Rede1");
            });

            modelBuilder.Entity<ContaBanco>(entity =>
            {
                entity.HasKey(e => e.IdContaBanco);

                entity.ToTable("ContaBanco", "RedeLojas");

                entity.HasIndex(e => e.IdBanco)
                    .HasName("fk_ContaBanco_Banco1_idx");

                entity.Property(e => e.IdContaBanco)
                    .HasColumnName("idContaBanco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Agencia)
                    .IsRequired()
                    .HasColumnName("agencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBanco)
                    .HasColumnName("idBanco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasColumnName("numero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo)
                    .HasColumnName("saldo")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.ContaBanco)
                    .HasForeignKey(d => d.IdBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ContaBanco_Banco1");
            });

            modelBuilder.Entity<Fornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);

                entity.ToTable("Fornecedor", "RedeLojas");

                entity.HasIndex(e => e.IdGrupoProduto)
                    .HasName("fk_Fornecedor_GrupoProduto1_idx");

                entity.Property(e => e.IdFornecedor)
                    .HasColumnName("idFornecedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EhFabricante)
                    .HasColumnName("ehFabricante")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdGrupoProduto)
                    .HasColumnName("idGrupoProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasColumnName("nomeFantasia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeRepresentante)
                    .HasColumnName("nomeRepresentante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefoneRepresentante)
                    .HasColumnName("telefoneRepresentante")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoProdutoNavigation)
                    .WithMany(p => p.Fornecedor)
                    .HasForeignKey(d => d.IdGrupoProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Fornecedor_GrupoProduto1");
            });

            modelBuilder.Entity<GrupoProduto>(entity =>
            {
                entity.HasKey(e => e.IdGrupoProduto);

                entity.ToTable("GrupoProduto", "RedeLojas");

                entity.HasIndex(e => e.IdRede)
                    .HasName("fk_GrupoProduto_Rede1_idx");

                entity.Property(e => e.IdGrupoProduto)
                    .HasColumnName("idGrupoProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRede)
                    .HasColumnName("idRede")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRedeNavigation)
                    .WithMany(p => p.GrupoProduto)
                    .HasForeignKey(d => d.IdRede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_GrupoProduto_Rede1");
            });

            modelBuilder.Entity<MovimentacaoBancaria>(entity =>
            {
                entity.HasKey(e => e.IdMovimentacaoBancaria);

                entity.ToTable("MovimentacaoBancaria", "RedeLojas");

                entity.HasIndex(e => e.IdConta)
                    .HasName("fk_MovimentacaoBancaria_Conta1_idx");

                entity.HasIndex(e => e.IdContaBanco)
                    .HasName("fk_MovimentacaoBancaria_ContaBanco1_idx");

                entity.HasIndex(e => e.IdRede)
                    .HasName("fk_MovimentacaoBancaria_Rede1_idx");

                entity.Property(e => e.IdMovimentacaoBancaria)
                    .HasColumnName("idMovimentacaoBancaria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataMovimentacao).HasColumnName("dataMovimentacao");

                entity.Property(e => e.IdConta)
                    .HasColumnName("idConta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdContaBanco)
                    .HasColumnName("idContaBanco")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRede)
                    .HasColumnName("idRede")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdContaNavigation)
                    .WithMany(p => p.MovimentacaoBancaria)
                    .HasForeignKey(d => d.IdConta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MovimentacaoBancaria_Conta1");

                entity.HasOne(d => d.IdContaBancoNavigation)
                    .WithMany(p => p.MovimentacaoBancaria)
                    .HasForeignKey(d => d.IdContaBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MovimentacaoBancaria_ContaBanco1");

                entity.HasOne(d => d.IdRedeNavigation)
                    .WithMany(p => p.MovimentacaoBancaria)
                    .HasForeignKey(d => d.IdRede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MovimentacaoBancaria_Rede1");
            });

            modelBuilder.Entity<Parceria>(entity =>
            {
                entity.HasKey(e => e.IdParceria);

                entity.ToTable("Parceria", "RedeLojas");

                entity.HasIndex(e => e.IdRede)
                    .HasName("fk_Parceria_Rede1_idx");

                entity.Property(e => e.IdParceria)
                    .HasColumnName("idParceria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataFim).HasColumnName("dataFim");

                entity.Property(e => e.DataInicio).HasColumnName("dataInicio");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IdRede)
                    .HasColumnName("idRede")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sitacao)
                    .IsRequired()
                    .HasColumnName("sitacao")
                    .HasColumnType("enum('ATIVO','INATIVO')")
                    .HasDefaultValueSql("ATIVO");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasColumnName("titulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRedeNavigation)
                    .WithMany(p => p.Parceria)
                    .HasForeignKey(d => d.IdRede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Parceria_Rede1");
            });

            modelBuilder.Entity<PlanoConta>(entity =>
            {
                entity.HasKey(e => e.IdPlanoConta);

                entity.ToTable("PlanoConta", "RedeLojas");

                entity.Property(e => e.IdPlanoConta)
                    .HasColumnName("idPlanoConta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.IdProduto);

                entity.ToTable("Produto", "RedeLojas");

                entity.HasIndex(e => e.IdGrupoProduto)
                    .HasName("fk_Produto_GrupoProduto1_idx");

                entity.Property(e => e.IdProduto)
                    .HasColumnName("idProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CodigoBarra)
                    .IsRequired()
                    .HasColumnName("codigoBarra")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoFabricante)
                    .HasColumnName("codigoFabricante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdGrupoProduto)
                    .HasColumnName("idGrupoProduto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFabricante)
                    .IsRequired()
                    .HasColumnName("nomeFabricante")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoProdutoNavigation)
                    .WithMany(p => p.Produto)
                    .HasForeignKey(d => d.IdGrupoProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Produto_GrupoProduto1");
            });

            modelBuilder.Entity<Rede>(entity =>
            {
                entity.HasKey(e => e.IdRede);

                entity.ToTable("Rede", "RedeLojas");

                entity.Property(e => e.IdRede)
                    .HasColumnName("idRede")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Logotipo)
                    .HasColumnName("logotipo")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeFantasia)
                    .IsRequired()
                    .HasColumnName("nomeFantasia")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RedeAssociado>(entity =>
            {
                entity.HasKey(e => new { e.IdRede, e.IdAssociado });

                entity.ToTable("RedeAssociado", "RedeLojas");

                entity.HasIndex(e => e.IdAssociado)
                    .HasName("fk_tb_associacao_tb_associado_tb_associado1_idx");

                entity.HasIndex(e => e.IdRede)
                    .HasName("fk_tb_associacao_tb_associado_tb_associacao_idx");

                entity.Property(e => e.IdRede)
                    .HasColumnName("idRede")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdAssociado)
                    .HasColumnName("idAssociado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EhAdministrador)
                    .HasColumnName("ehAdministrador")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdAssociadoNavigation)
                    .WithMany(p => p.RedeAssociado)
                    .HasForeignKey(d => d.IdAssociado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_associacao_tb_associado_tb_associado1");

                entity.HasOne(d => d.IdRedeNavigation)
                    .WithMany(p => p.RedeAssociado)
                    .HasForeignKey(d => d.IdRede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tb_associacao_tb_associado_tb_associacao");
            });
        }
    }
}
