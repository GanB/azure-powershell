---
external help file: Az.Network-help.xml
Module Name: Az.Network
online version: https://docs.microsoft.com/en-us/powershell/module/az.network/get-azvirtualnetwork
schema: 2.0.0
---

# Get-AzVirtualNetwork

## SYNOPSIS
Gets the specified virtual network by resource group.

## SYNTAX

### ListSubscriptionIdViaHost (Default)
```
Get-AzVirtualNetwork [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetSubscriptionIdViaHost
```
Get-AzVirtualNetwork -Name <String> -ResourceGroupName <String> [-Expand <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### Get
```
Get-AzVirtualNetwork -Name <String> -ResourceGroupName <String> -SubscriptionId <String> [-Expand <String>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ListSubscriptionIdViaHost1
```
Get-AzVirtualNetwork -ResourceGroupName <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List1
```
Get-AzVirtualNetwork -ResourceGroupName <String> -SubscriptionId <String> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### List
```
Get-AzVirtualNetwork -SubscriptionId <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets the specified virtual network by resource group.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Expand
Expands referenced resources.

```yaml
Type: System.String
Parameter Sets: GetSubscriptionIdViaHost, Get
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the virtual network.

```yaml
Type: System.String
Parameter Sets: GetSubscriptionIdViaHost, Get
Aliases: VirtualNetworkName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.

```yaml
Type: System.String
Parameter Sets: GetSubscriptionIdViaHost, Get, ListSubscriptionIdViaHost1, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription credentials which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: Get, List1, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Network.Models.Api20190201.IVirtualNetwork
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.network/get-azvirtualnetwork](https://docs.microsoft.com/en-us/powershell/module/az.network/get-azvirtualnetwork)
