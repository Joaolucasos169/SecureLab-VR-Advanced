# SecureLab VR

## Descrição Geral
**SecureLab VR: Simulação de Engenharia Social** é um projeto conceitual em Realidade Virtual que simula um ambiente corporativo imersivo (laboratório de TI) para treinar novos funcionários na identificação de ataques de engenharia social, com foco na técnica de **Baiting** por meio de pendrives maliciosos.

## Especificações Técnicas
- **Engine:** Unity 6 (6000.0.75f1 LTS)
- **SDK de VR:** Meta XR All-in-One SDK
- **Plataforma de destino:** Android (Meta Quest 2 e Meta Quest 3)
- **Compressão de textura:** ASTC
- **Simulação em editor:** XR Device Simulator

## Escopo dos Assets
- **Tech_Workbench**: mesa de laboratório utilizada como ponto principal de interação.
- **Malicious_USB_Drive**: pendrive interativo usado na simulação de ameaça.
- **Secure_Drop_Box**: lixeira de descarte seguro com componente `Trigger` para validar comportamento seguro.
- **SFX_Alert_Success**: áudio de feedback para sinalizar descarte correto.

## Estrutura de Pastas (Simulada)
```text
/Assets
  /Audio
  /Materials
  /Prefabs
  /Scenes
  /Scripts
/ProjectSettings
```

## Script Conceitual de Interação
Arquivo esperado:

`/Assets/Scripts/InteracaoSimples.cs`

Esse script detecta quando um objeto com a tag `MaliciousUSB` entra na área de descarte seguro, toca um áudio tridimensional de sucesso e destrói o pendrive malicioso.
