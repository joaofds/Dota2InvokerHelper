# Dota2InvokerHelper
Dota2 Invoker Helper - O app permite configurar atalhos personalizados, capturar hotkeys e enviar comandos de teclado de forma prática, otimizando a experiência durante partidas.

## Funcionalidades
- Mapeamento de teclas personalizadas (até dois atalhos por habilidade).
- Envia a sequência de teclas somente para a janela do jogo.
- Toggle global via `Pause/Break` para ativar ou desativar todos os atalhos em tempo real.
- Interface gráfica para configurar os atalhos sem editar arquivos manualmente.

## Requisitos
- Windows (utiliza WinAPI para captura global de teclado)
- .NET 10 Runtime

## Download

Você pode baixar o pacote do aplicativo aqui:

[Download dota2_invoker_helper.rar](https://github.com/joaofds/Dota2InvokerHelper/raw/main/download/dota2_invoker_helper.rar)

## Configuração

O Dota2InvokerHelper utiliza um arquivo chamado `config.json` para definir as teclas de orbes, invocação e as combinações de atalhos para cada habilidade do Invoker. Você pode personalizar as teclas via interface gráfica (botão **Configurar Atalhos**) ou editando o arquivo diretamente.

| Campo | Descrição | Padrão |
|-------|-----------|--------|
| `WindowName` | Título da janela do jogo | `"Dota 2"` |
| `QuasKey` | Tecla do orbe Quas | `"q"` |
| `WexKey` | Tecla do orbe Wex | `"w"` |
| `ExortKey` | Tecla do orbe Exort | `"e"` |
| `InvokeKey` | Tecla de invocação | `"r"` |
| `FirstSpellKey` | Tecla do primeiro slot de habilidade | `"d"` |
| `SecondSpellKey` | Tecla do segundo slot de habilidade | `"f"` |
| `KeyCombos` | Mapeamento de atalhos por habilidade (editável pela UI) | — |

## Atalhos

A tecla `Pause/Break` ativa ou desativa todos os atalhos globalmente a qualquer momento.

Os atalhos padrão das habilidades são:

- **Cold Snap**: `space+q`
- **EMP**: `space+w`
- **Sun Strike**: `space+e`
- **Tornado**: `space+t`
- **Chaos Meteor**: `space+3`
- **Deafening Blast**: `space+4`
- **Ice Wall**: `space+v`
- **Ghost Walk**: `space+b`
- **Panic Ghost Walk**: `space+g` — invoca Ghost Walk e ativa imediatamente
- **Alacrity**: `space+1`
- **Forge Spirit**: `space+f`

## Imagens

### Janela Principal
![Janela Principal](images/main_window.jpg)

### Janela de Atalhos
![Janela de Atalhos](images/shortcuts_window.jpg)
