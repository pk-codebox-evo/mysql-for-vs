/*
 * Copyright (c) 2015, Oracle and/or its affiliates. All rights reserved.
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation; version 2 of the
 * License.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA
 * 02110-1301  USA
 */


#ifndef _MYSQLD_CONTEXT_SSL_H_
#define _MYSQLD_CONTEXT_SSL_H_

#include <boost/asio/buffer.hpp>
#include <queue>


namespace mysqld
{

  void set_context(SSL_CTX* ssl_context, const bool is_client, const std::string &ssl_key,
                   const std::string &ssl_cert,    const std::string &ssl_ca,
                   const std::string &ssl_ca_path, const std::string &ssl_cipher,
                   const std::string &ssl_crl,     const std::string &ssl_crl_path);

}  // namespace mysqld


#endif // _MYSQLD_CONTEXT_SSL_H_
