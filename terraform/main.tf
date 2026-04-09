resource "azurerm_aadb2c_directory" "this" {
  domain_name             = local.b2c_domain_name
  display_name            = local.b2c_display_name
  resource_group_name     = data.azurerm_resource_group.default_resource_group.name
  data_residency_location = "Europe"
  country_code            = var.b2c_country_code
  sku_name                = var.b2c_sku
}
