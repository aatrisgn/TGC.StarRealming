locals {
  app_name = "starrealming"

  resource_group_name = "rg-${local.app_name}-b2c-${var.environment}-${var.region_shortcode}"
  b2c_domain_name     = "${local.app_name}${var.environment}.onmicrosoft.com"
  b2c_display_name    = "StarRealming ${upper(var.environment)}"
}
