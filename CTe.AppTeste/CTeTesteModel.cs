﻿using System.Windows.Forms;
using CTe.AppTeste.Dao;
using CTe.AppTeste.Entidades;
using CTe.AppTeste.ModelBase;
using CTeDLL;
using CTeDLL.Classes.Servicos.Tipos;
using DFe.Classes.Entidades;
using DFe.Classes.Flags;
using DFe.Utils;
using DFe.Utils.Assinatura;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace CTe.AppTeste
{
    public class CTeTesteModel : ViewModel
    {
        private string _rntrc;
        private string _cnpj;
        private string _inscricaoEstadual;
        private string _nome;
        private string _nomeFantasia;
        private string _logradouro;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private long _codigoIbgeMunicipio;
        private string _nomeMunicipio;
        private string _cep;
        private Estado _siglaUf;
        private string _telefone;
        private string _email;
        private string _numeroDeSerie;
        private string _caminhoArquivo;
        private string _senha;
        private bool _manterCertificadoEmCache;
        private string _diretorioSalvarXml;
        private bool _isSalvarXml;
        private Estado _ufDestino;
        private TipoAmbiente _ambiente;
        private short _serie;
        private long _numeracao;
        private bool _ambienteProducao;
        private bool _ambienteHomologacao;
        private string _diretorioSchemas;
        private int _timeOut;
        private versao _versaoLayout;

        #region empresa

        public string Rntrc
        {
            get { return _rntrc; }
            set
            {
                _rntrc = value;
                OnPropertyChanged("Rntrc");
            }
        }

        public string Cnpj
        {
            get { return _cnpj; }
            set
            {
                _cnpj = value;
                OnPropertyChanged("Cnpj");
            }
        }

        public string InscricaoEstadual
        {
            get { return _inscricaoEstadual; }
            set
            {
                _inscricaoEstadual = value;
                OnPropertyChanged("InscricaoEstadual");
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }

        public string NomeFantasia
        {
            get { return _nomeFantasia; }
            set
            {
                _nomeFantasia = value;
                OnPropertyChanged("NomeFantasia");
            }
        }

        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                _logradouro = value;
                OnPropertyChanged("Logradouro");
            }
        }

        public string Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
                OnPropertyChanged("Numero");
            }
        }

        public string Complemento
        {
            get { return _complemento; }
            set
            {
                _complemento = value;
                OnPropertyChanged("Complemento");
            }
        }

        public string Bairro
        {
            get { return _bairro; }
            set
            {
                _bairro = value;
                OnPropertyChanged("Bairro");
            }
        }

        public long CodigoIbgeMunicipio
        {
            get { return _codigoIbgeMunicipio; }
            set
            {
                _codigoIbgeMunicipio = value;
                OnPropertyChanged("CodigoIbgeMunicipio");
            }
        }

        public string NomeMunicipio
        {
            get { return _nomeMunicipio; }
            set
            {
                _nomeMunicipio = value;
                OnPropertyChanged("NomeMunicipio");
            }
        }

        public string Cep
        {
            get { return _cep; }
            set
            {
                _cep = value;
                OnPropertyChanged("Cep");
            }
        }

        public Estado SiglaUf
        {
            get { return _siglaUf; }
            set
            {
                _siglaUf = value;
                OnPropertyChanged("SiglaUf");
            }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = value;
                OnPropertyChanged("Telefone");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        #endregion

        #region certificado

        public string NumeroDeSerie
        {
            get { return _numeroDeSerie; }
            set
            {
                _numeroDeSerie = value;
                OnPropertyChanged("NumeroDeSerie");
            }
        }

        public string CaminhoArquivo
        {
            get { return _caminhoArquivo; }
            set
            {
                _caminhoArquivo = value;
                OnPropertyChanged("CaminhoArquivo");
            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
                OnPropertyChanged("Senha");
            }
        }

        public bool ManterCertificadoEmCache
        {
            get { return _manterCertificadoEmCache; }
            set
            {
                _manterCertificadoEmCache = value;
                OnPropertyChanged("ManterCertificadoEmCache");
            }
        }

        #endregion

        #region configWebService

        public Estado UfDestino
        {
            get { return _ufDestino; }
            set
            {
                _ufDestino = value;
                OnPropertyChanged("UfDestino");
            }
        }

        public TipoAmbiente Ambiente
        {
            get { return _ambiente; }
            set
            {
                _ambiente = value;
                OnPropertyChanged("Ambiente");
            }
        }

        public short Serie
        {
            get { return _serie; }
            set
            {
                _serie = value;
                OnPropertyChanged("Serie");
            }
        }

        public long Numeracao
        {
            get { return _numeracao; }
            set
            {
                _numeracao = value;
                OnPropertyChanged("Numeracao");
            }
        }

        public versao VersaoLayout
        {
            get { return _versaoLayout; }
            set
            {
                _versaoLayout = value;
                OnPropertyChanged("VersaoLayout");
            }
        }

        public bool AmbienteProducao
        {
            get { return _ambienteProducao; }
            set
            {
                _ambienteProducao = value;
                OnPropertyChanged("AmbienteProducao");
            }
        }

        public bool AmbienteHomologacao
        {
            get { return _ambienteHomologacao; }
            set
            {
                _ambienteHomologacao = value;
                OnPropertyChanged("AmbienteHomologacao");
            }
        }

        public string DiretorioSchemas
        {
            get { return _diretorioSchemas; }
            set
            {
                _diretorioSchemas = value;
                OnPropertyChanged("DiretorioSchemas");
            }
        }

        public int TimeOut
        {
            get { return _timeOut; }
            set
            {
                _timeOut = value;
                OnPropertyChanged("TimeOut");
            }
        }

        #endregion

        #region configuração arquivo
        public string DiretorioSalvarXml
        {
            get { return _diretorioSalvarXml; }
            set
            {
                _diretorioSalvarXml = value;
                OnPropertyChanged("DiretorioSalvarXml");
            }
        }

        public bool IsSalvarXml
        {
            get { return _isSalvarXml; }
            set
            {
                _isSalvarXml = value;
                OnPropertyChanged("IsSalvarXml");
            }
        }

        #endregion configuração arquivo

        public void SalvarConfiguracoesXml()
        {
            var configuracaoDao = new ConfiguracaoDao();
            var configuracaoAppTeste = new Configuracao
            {
                Empresa =
                    {
                        Cnpj = Cnpj,
                        Bairro = Bairro,
                        Cep = Cep,
                        CodigoIbgeMunicipio = CodigoIbgeMunicipio,
                        Complemento = Complemento,
                        Email = Email,
                        InscricaoEstadual = InscricaoEstadual,
                        Logradouro = Logradouro,
                        Nome = Nome,
                        NomeFantasia = NomeFantasia,
                        NomeMunicipio = NomeMunicipio,
                        Numero = Numero,
                        SiglaUf = SiglaUf,
                        Telefone = Telefone,
                        RNTRC = Rntrc
                    },
                CertificadoDigital =
                {
                    CaminhoArquivo = CaminhoArquivo,
                    NumeroDeSerie = NumeroDeSerie,
                    Senha = Senha,
                    ManterEmCache = ManterCertificadoEmCache
                },
                ConfigWebService =
                {
                    UfEmitente = UfDestino,
                    Numeracao = Numeracao,
                    Serie = Serie,
                    Versao = VersaoLayout,
                    CaminhoSchemas = DiretorioSchemas,
                    TimeOut = TimeOut
                },
                DiretorioSalvarXml = DiretorioSalvarXml,
                IsSalvarXml = IsSalvarXml
            };

            if (AmbienteHomologacao)
                configuracaoAppTeste.ConfigWebService.Ambiente = TipoAmbiente.Homologacao;

            if (AmbienteProducao)
                configuracaoAppTeste.ConfigWebService.Ambiente = TipoAmbiente.Producao;


            configuracaoDao.SalvarConfiguracao(configuracaoAppTeste);
        }

        public void ObterSerialCertificado()
        {
            NumeroDeSerie = CertificadoDigital.ListareObterDoRepositorio().SerialNumber;
        }

        public void ObterCertificadoArquivo()
        {
            var janelaArquivo = new OpenFileDialog
            {
                Filter = "Certificado digital(*.pfx)|*.pfx"
            };
            if (janelaArquivo.ShowDialog() == true)
            {
                CaminhoArquivo = janelaArquivo.FileName;
            }
        }

        public void CarregarConfiguracoes()
        {
            var dao = new ConfiguracaoDao();
            var config = dao.BuscarConfiguracao();

            if (config == null) return;

            Cnpj = config.Empresa.Cnpj;
            Bairro = config.Empresa.Bairro;
            Cep = config.Empresa.Cep;
            CodigoIbgeMunicipio = config.Empresa.CodigoIbgeMunicipio;
            Complemento = config.Empresa.Complemento;
            Email = config.Empresa.Email;
            InscricaoEstadual = config.Empresa.InscricaoEstadual;
            Logradouro = config.Empresa.Logradouro;
            Nome = config.Empresa.Nome;
            NomeFantasia = config.Empresa.NomeFantasia;
            NomeMunicipio = config.Empresa.NomeMunicipio;
            Numero = config.Empresa.Numero;
            SiglaUf = config.Empresa.SiglaUf;
            Telefone = config.Empresa.Telefone;
            Rntrc = config.Empresa.RNTRC;

            Senha = config.CertificadoDigital.Senha;
            ManterCertificadoEmCache = config.CertificadoDigital.ManterEmCache;
            CaminhoArquivo = config.CertificadoDigital.CaminhoArquivo;
            NumeroDeSerie = config.CertificadoDigital.NumeroDeSerie;


            AmbienteProducao = true;

            if (config.ConfigWebService.Ambiente == TipoAmbiente.Homologacao)
                AmbienteHomologacao = true;

            Numeracao = config.ConfigWebService.Numeracao;
            Serie = config.ConfigWebService.Serie;

            UfDestino = config.ConfigWebService.UfEmitente;

            VersaoLayout = config.ConfigWebService.Versao;

            DiretorioSchemas = config.ConfigWebService.CaminhoSchemas;
            DiretorioSalvarXml = config.DiretorioSalvarXml;
            IsSalvarXml = config.IsSalvarXml;
            TimeOut = 3000;

            if (config.ConfigWebService.TimeOut > 0)
            {
                TimeOut = config.ConfigWebService.TimeOut;
            }
        }

        public void BuscarDiretorioSchema()
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            DiretorioSchemas = dlg.SelectedPath;
        }

        public void BuscarDiretorioSalvarXml()
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            DiretorioSalvarXml = dlg.SelectedPath;
        }

        private static void CarregarConfiguracoes(Configuracao config)
        {
            var configuracaoCertificado = new ConfiguracaoCertificado
            {
                Arquivo = config.CertificadoDigital.CaminhoArquivo,
                ManterDadosEmCache = config.CertificadoDigital.ManterEmCache,
                Serial = config.CertificadoDigital.NumeroDeSerie
            };


            ConfiguracaoServico.Instancia.Certificado = configuracaoCertificado;
            ConfiguracaoServico.Instancia.TimeOut = config.ConfigWebService.TimeOut;
            ConfiguracaoServico.Instancia.cUF = config.ConfigWebService.UfEmitente;
            ConfiguracaoServico.Instancia.tpAmb = config.ConfigWebService.Ambiente;
            ConfiguracaoServico.Instancia.VersaoLayout = config.ConfigWebService.Versao;
            ConfiguracaoServico.Instancia.DiretorioSchemas = config.ConfigWebService.CaminhoSchemas;
            ConfiguracaoServico.Instancia.IsSalvarXml = config.IsSalvarXml;
            ConfiguracaoServico.Instancia.DiretorioSalvarXml = config.DiretorioSalvarXml;
        }
    }
}