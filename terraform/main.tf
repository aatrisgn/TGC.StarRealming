resource "azurerm_dns_zone" "apex" {
  name                = "starrealming.com"
  resource_group_name = data.azurerm_resource_group.default_resource_group.name
}