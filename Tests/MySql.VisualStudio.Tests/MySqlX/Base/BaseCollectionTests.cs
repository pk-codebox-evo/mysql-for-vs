﻿// Copyright © 2016, Oracle and/or its affiliates. All rights reserved.
//
// MySQL for Visual Studio is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most
// MySQL Connectors. There are special exceptions to the terms and
// conditions of the GPLv2 as it is applied to this software, see the
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License
// for more details.
//
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

namespace MySql.VisualStudio.Tests.MySqlX.Base
{
  public class BaseCollectionTests : BaseTests
  {
    #region Constant Values

    /// <summary>
    /// Bound array value.
    /// </summary>
    protected const string MOVIES_ACTORS_ARRAY_VALUE = "['ADAM GRANT', 'CATE MCQUEEN', 'GRETA KEITEL']";

    /// <summary>
    /// The duplicate title used for testing uniqueness in sakila_x.movies.
    /// </summary>
    protected const string MOVIES_DUPLICATE_TITLE = "BAKED CLEOPATRA";

    /// <summary>
    /// The name of the non-unique index created on the movies collection.
    /// </summary>
    protected const string MOVIES_NON_UNIQUE_INDEX_NAME = "rating_index";

    /// <summary>
    /// The name of the unique index created on the movies collection.
    /// </summary>
    protected const string MOVIES_UNIQUE_INDEX_NAME = "title_index";

    /// <summary>
    /// Bound array value.
    /// </summary>
    protected const string MOVIES_RATING_ARRAY_VALUE = "['R', 'NC-17']";

    /// <summary>
    /// The total count of rating = R movies.
    /// </summary>
    protected const int MOVIES_RATING_R_COUNT = 195;

    /// <summary>
    /// The total users count.
    /// </summary>
    protected const int USERS_COUNT = 10;

    #endregion Constant Values

    #region JavaScript specific

    /// <summary>
    /// Statement to attempt to add a duplicate movie to the sakila_x.movies collection.
    /// </summary>
    protected const string JAVASCRIPT_ADD_DUPLICATE_MOVIE = "coll.add({ title: '" + MOVIES_DUPLICATE_TITLE + "', description: 'Trying to insert a duplicate title into the movies collection', release_year: 2006, language: 'English', duration: '182 min', rating: 'DEL', actors: ['MICHELLE MCCONAUGHEY'] }).execute()";

    /// <summary>
    /// Statement to add a single user to the sakila_x.users collection.
    /// </summary>
    protected const string JAVASCRIPT_ADD_SINGLE_USER1 = "coll.add({ name: 'Javier Trevino', email: 'javier.trevino@oracle.com', password: 'Lopkhue01', test: 'yes' }).execute()";

    /// <summary>
    /// Statement to add a single user to the sakila_x.users collection.
    /// </summary>
    protected const string JAVASCRIPT_ADD_SINGLE_USER2 = "coll.add({ name: 'Alfonso Penunuri', email: 'luis.penunuri@oracle.com', password: 'Lopkhue02', test: 'yes' }).execute()";

    /// <summary>
    /// Statement to insert multiple records on a single statement chaining add methods.
    /// </summary>
    protected const string JAVASCRIPT_ADD_MULTIPLE_USERS_MULTIPLE_ADD = "coll.add({ name: 'Javier Rivera', email: 'javier.rivera@oracle.com', password: 'Amjfadur01', test: 'yes' })"
      + ".add({ name: 'Francisco Tirado', email: 'francisco.tirado@oracle.com', password: 'Amjfadur02', test: 'yes' })"
      + ".add({ name: 'Ignacio Galarza', email: 'iggy.galarza@oracle.com', password: 'Amjfadur03', test: 'yes' }).execute()";

    /// <summary>
    /// Statement to insert multiple records on a single statement with a single add but an array of documents.
    /// </summary>
    protected const string JAVASCRIPT_ADD_MULTIPLE_USERS_SINGLE_ADD = "coll.add([{ name: 'Mike Zinner', email: 'mike.zinner@oracle.com', password: 'Supr3m3B0ss', test: 'yes' },"
      + "{ name: 'Reggie Burnett', email: 'reggie.burnett@oracle.com', password: 'Burn3tt2016', test: 'yes' },"
      + "{ name: 'Johannes Taxacher', email: 'johannes.taxacher@oracle.com', password: 'Tax98uk,', test: 'yes' }]).execute()";

    /// <summary>
    /// Statement to modify a SakilaX.User value and set additional values.
    /// </summary>
    protected const string JAVASCRIPT_MODIFY_MERGE_USER = "coll.modify('name like :param1').merge({ status: 'inactive', ratings: "
      + MOVIES_RATING_ARRAY_VALUE
      + " }).bind('param1', 'Iggy%').execute()";
    #endregion JavaScript specific

    #region Python specific

    /// <summary>
    /// Statement to attempt to add a duplicate movie to the sakila_x.movies collection.
    /// </summary>
    protected const string PYTHON_ADD_DUPLICATE_MOVIE = "coll.add({ 'title': '" + MOVIES_DUPLICATE_TITLE + "', 'description': 'Trying to insert a duplicate title into the movies collection', 'release_year': 2006, 'language': 'English', 'duration': '182 min', 'rating': 'DEL', 'actors': ['MICHELLE MCCONAUGHEY'] }).execute()";

    /// <summary>
    /// Statement to add a single user to the sakila_x.users collection.
    /// </summary>
    protected const string PYTHON_ADD_SINGLE_USER1 = "coll.add({'name': 'Javier Trevino', 'email': 'javier.trevino@oracle.com', 'password': 'Lopkhue01', 'test': 'yes'}).execute()";

    /// <summary>
    /// Statement to add a single user to the sakila_x.users collection.
    /// </summary>
    protected const string PYTHON_ADD_SINGLE_USER2 = "coll.add({'name': 'Alfonso Penunuri', 'email': 'luis.penunuri@oracle.com', 'password': 'Lopkhue02', 'test': 'yes'}).execute()";

    /// <summary>
    /// Statement to insert multiple records on a single statement chaining add methods.
    /// </summary>
    protected const string PYTHON_ADD_MULTIPLE_USERS_MULTIPLE_ADD = "coll.add({'name': 'Javier Rivera', 'email': 'javier.rivera@oracle.com', 'password': 'Amjfadur01', 'test': 'yes'})"
      + ".add({'name': 'Francisco Tirado', 'email': 'francisco.tirado@oracle.com', 'password': 'Amjfadur02', 'test': 'yes'})"
      + ".add({'name': 'Ignacio Galarza', 'email': 'iggy.galarza@oracle.com', 'password': 'Amjfadur03', 'test': 'yes'}).execute()";

    /// <summary>
    /// Statement to insert multiple records on a single statement with a single add but an array of documents.
    /// </summary>
    protected const string PYTHON_ADD_MULTIPLE_USERS_SINGLE_ADD = "coll.add([{'name': 'Mike Zinner', 'email': 'mike.zinner@oracle.com', 'password': 'Supr3m3B0ss', 'test': 'yes'},"
      + "{'name': 'Reggie Burnett', 'email': 'reggie.burnett@oracle.com', 'password': 'Burn3tt2016', 'test': 'yes'},"
      + "{'name': 'Johannes Taxacher', 'email': 'johannes.taxacher@oracle.com', 'password': 'Tax98uk,', 'test': 'yes'}]).execute()";

    /// <summary>
    /// Statement to modify a SakilaX.User value and set additional values.
    /// </summary>
    protected const string PYTHON_MODIFY_MERGE_USER = "coll.modify('name like :param1').merge({ 'status': 'inactive', 'ratings': "
      + MOVIES_RATING_ARRAY_VALUE
      + " }).bind('param1', 'Iggy%').execute()";

    #endregion Python specific

    #region Common Collection Queries

    /// <summary>
    /// Statement to create a collection.
    /// </summary>
    protected const string CREATE_COLLECTION = "session.getSchema('{0}').createCollection('{1}')";

    /// <summary>
    /// Statement to create a schema.
    /// </summary>
    protected const string CREATE_SCHEMA = "session.createSchema('{0}')";

    /// <summary>
    /// Statement to create a non-unique index.
    /// </summary>
    protected const string CREATE_NON_UNIQUE_INDEX_MOVIES = "coll.createIndex('" + MOVIES_NON_UNIQUE_INDEX_NAME + "').field('rating', 'text(5)', true).execute()";

    /// <summary>
    /// Statement to create a unique index.
    /// </summary>
    protected const string CREATE_UNIQUE_INDEX_MOVIES = "coll.createIndex('" + MOVIES_UNIQUE_INDEX_NAME + "', mysqlx.IndexType.Unique).field('title', 'text(255)', true).execute()";

    /// <summary>
    /// Statement to drop a collection.
    /// </summary>
    protected const string DROP_COLLECTION = "session.dropCollection('{0}', '{1}')";

    /// <summary>
    /// Statement to drop non-unique index.
    /// </summary>
    protected const string DROP_NON_UNIQUE_INDEX_MOVIES = "coll.dropIndex('" + MOVIES_NON_UNIQUE_INDEX_NAME + "').execute()";

    /// <summary>
    /// Statement to drop unique index.
    /// </summary>
    protected const string DROP_UNIQUE_INDEX_MOVIES = "coll.dropIndex('" + MOVIES_UNIQUE_INDEX_NAME + "').execute()";

    /// <summary>
    /// Statement to drop the test database
    /// </summary>
    protected const string DROP_SCHEMA = "session.dropSchema('{0}')";

    /// <summary>
    /// Statement to get all the records from the test table as RowResult
    /// </summary>
    protected const string FIND_ALL_DOCUMENTS_IN_COLLECTION = "coll.find().execute()";

    /// <summary>
    /// Statement to get all the movies with a duplicate movie title of MOVIES_DUPLICATE_TITLE.
    /// </summary>
    protected const string FIND_DUPLICATE_MOVIE_TITLE = "coll.find('title = :param1').bind('param1', '" + MOVIES_DUPLICATE_TITLE + "').execute()";

    /// <summary>
    /// Statement to select the update record from the test table
    /// </summary>
    protected const string FIND_SPECIFIC_USER_TEST = "coll.find('name like :param1').bind('param1', 'Reggie%').execute()";

    /// <summary>
    /// Statement to find the updated SakilaX.User document.
    /// </summary>
    protected const string FIND_MODIFIED_USER = "coll.find('name like :findParam').bind('findParam', 'Iggy%').execute()";

    /// <summary>
    /// Statement to find the updated SakilaX.User document.
    /// </summary>
    protected const string FIND_MODIFIED_J_USERS = "coll.find('name like :param1 and status = :param2').bind('param1', 'Javier%').bind('param2', 'tocayo').execute()";

    /// <summary>
    /// Statement to find records with a complex query.
    /// </summary>
    protected const string FIND_MOVIES_COMPLEX_QUERY1 = "complexQuery = coll.find('rating = :param1').fields(['rating', 'title', 'description', 'duration']).sort(['release_year'])";

    /// <summary>
    /// Statement to find records with a complex query.
    /// </summary>
    protected const string FIND_MOVIES_COMPLEX_QUERY2 = "complexQuery2 = coll.find('rating = :param1').fields(['rating', 'title', 'description', 'duration']).sort(['release_year']).limit(10).skip(5)";

    /// <summary>
    /// Statement to find records with a complex query.
    /// </summary>
    protected const string FIND_MOVIES_COMPLEX_QUERY3 = "complexQuery.bind('param1', 'R').execute()";

    /// <summary>
    /// Statement to find records with a complex query.
    /// </summary>
    protected const string FIND_MOVIES_COMPLEX_QUERY4 = "complexQuery2.bind('param1', 'R').execute()";

    /// <summary>
    /// Statement to find a specific record using a bound array.
    /// </summary>
    protected const string FIND_MOVIES_BOUND_ARRAY = "coll.find('actors = :param1').fields(['_id', 'title', 'duration', 'actors']).bind('param1', "+ MOVIES_ACTORS_ARRAY_VALUE + ").execute()";

    /// <summary>
    /// Statement to find users that were removed with REMOVE_SORT_USER.
    /// </summary>
    protected const string FIND_REMOVED_USERS = "coll.find('name like :param1 or name like :param2').bind('param1', 'Fr%').bind('param2', 'Ig%').execute()";

    /// <summary>
    /// Get a specific colletion and assign it to a variable for persistence. 
    /// </summary>
    protected const string GET_COLLECTION = "coll = session.getSchema('{0}').getCollection('{1}')";

    /// <summary>
    /// Gets a schema and assign it to a variable for persistence.
    /// </summary>
    protected const string GET_SCHEMA = "schema = session.getSchema('{0}')";

    /// <summary>
    /// Statement to modify a SakilaX.User value and append a value to a specific array.
    /// </summary>
    protected const string MODIFY_ARRAY_APPEND_USER = "coll.modify('name like :param1').arrayAppend('ratings', 'PG-13').bind('param1', 'Iggy%').execute()";

    /// <summary>
    /// Statement to modify a SakilaX.User value and insert a value to a specific array in a specified position.
    /// </summary>
    protected const string MODIFY_ARRAY_DELETE_USER = "coll.modify('name like :param1').arrayDelete('ratings[2]').bind('param1', 'Iggy%').execute()";

    /// <summary>
    /// Statement to modify a SakilaX.User value and insert a value to a specific array in a specified position.
    /// </summary>
    protected const string MODIFY_ARRAY_INSERT_USER = "coll.modify('name like :param1').arrayInsert('ratings[2]', 'G').bind('param1', 'Iggy%').execute()";

    /// <summary>
    /// Expression evaluation.
    /// </summary>
    protected const string MODIFY_SET_EXPRESSION = "mysqlx.expr('60 / 2 + 8')";

    /// <summary>
    /// Statement to modify a SakilaX.User value and set additional values.
    /// </summary>
    protected const string MODIFY_SET_USER = "coll.modify('name like :param1').set('name', 'Iggy Galarza').set('status', 'inactive').set('age', "+ MODIFY_SET_EXPRESSION + ").bind('param1', 'Ignacio%').execute()";

    /// <summary>
    /// Statement to set a SakilaX.User with a new value using a bound array.
    /// </summary>
    protected const string MODIFY_SET_BINDING_ARRAY_USER = "coll.modify('name like :param1').set('ratings', " + MOVIES_RATING_ARRAY_VALUE + ").bind('param1', 'Iggy%').execute()";

    /// <summary>
    /// Statement to modify a SakilaX.User value and set additional values in a specific order.
    /// </summary>
    protected const string MODIFY_SORT_USER = "coll.modify('name like :param1').set('status', 'tocayo').sort(['name']).limit(2).bind('param1', 'J%').execute()";

    /// <summary>
    /// Statement to unset a SakilaX.User value.
    /// </summary>
    protected const string MODIFY_UNSET_USER = "coll.modify('name like :param1').unset('age').bind('param1', 'Iggy%').execute()";

    /// <summary>
    /// Statement to unset a SakilaX.User a list of keys.
    /// </summary>
    protected const string MODIFY_UNSET_LIST_USER = "coll.modify('name like :param1').unset(['status', 'ratings']).bind('param1', 'Iggy%').execute()";

    /// <summary>
    /// Statement to delete a specific record in SakilaX.User
    /// </summary>
    protected const string REMOVE_USER = "coll.remove('name like :param').bind('param', 'Alfonso%').execute()";

    /// <summary>
    /// Statement to delete a test duplicate movie record.
    /// </summary>
    protected const string REMOVE_DUPLICATE_MOVIE = "coll.remove('title = :param1 and rating = :param2').bind('param1', '" + MOVIES_DUPLICATE_TITLE + "').bind('param2', 'DEL').execute()";

    /// <summary>
    /// Statement to delete the first x sorted records in SakilaX.User
    /// </summary>
    protected const string REMOVE_SORT_USER = "coll.remove('test = :param1').sort(['name']).limit(2).bind('param1', 'yes').execute()";

    /// <summary>
    /// Statement to remove the added users and revert the collection back to how it was.
    /// </summary>
    protected const string REVERT_ADDED_USERS = "coll.remove('test = :param1').bind('param1', 'yes').execute()";

    #endregion Common Collection Queries

    #region Common Session Queries
    /// <summary>
    /// Statement to validate whether the active session is open.
    /// </summary>
    protected const string IS_SESSION_OPEN = "session.isOpen()";

    /// <summary>
    /// Statement to get the parsed Uri of the active session Uri.
    /// </summary>
    protected const string SHELL_PARSE_URI_FROM_SESSION_URI = "shell.parseUri(session.getUri())";
    #endregion

    #region Properties

    /// <summary>
    /// Statement to create the test collection.
    /// </summary>
    public string CreateCollectionTest { get; private set; }

    /// <summary>
    /// Statement to create the test schema.
    /// </summary>
    public string CreateSchemaTest { get; private set; }

    /// <summary>
    /// Statement to drop the test collection.
    /// </summary>
    public string DropCollectionTest { get; private set; }

    /// <summary>
    /// Statement to drop the test schema.
    /// </summary>
    public string DropSchemaTest { get; private set; }

    /// <summary>
    /// Statement to drop the test database
    /// </summary>
    public string DropSchemaTestIfExists { get; private set; }

    /// <summary>
    /// Statement to get the movies collection from the SakilaX schema.
    /// </summary>
    public string GetCollectionSakilaXMovies { get; private set; }

    /// <summary>
    /// Statement to get the user collection from the SakilaX schema.
    /// </summary>
    public string GetCollectionSakilaXUser { get; private set; }

    /// <summary>
    /// Statement to get the SakilaX schema.
    /// </summary>
    public string GetSchemaSakilaX { get; private set; }

    /// <summary>
    /// Statement to get the Test schema.
    /// </summary>
    public string GetSchemaTest { get; private set; }

    /// <summary>
    /// Statement to get the collection_test collection from the Test schema.
    /// </summary>
    public string GetCollectionTestSchemaTest { get; private set; }

    #endregion Properties

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseCollectionTests"/> class.
    /// </summary>
    public BaseCollectionTests()
    {
      CreateCollectionTest = string.Format(CREATE_COLLECTION, TEST_SCHEMA_NAME, TEST_COLLECTION_NAME);
      CreateSchemaTest = string.Format(CREATE_SCHEMA, TEST_SCHEMA_NAME);
      DropCollectionTest = string.Format(DROP_COLLECTION, TEST_SCHEMA_NAME, TEST_COLLECTION_NAME);
      DropSchemaTest = string.Format(DROP_SCHEMA, TEST_SCHEMA_NAME);
      DropSchemaTestIfExists = string.Format(DROP_SCHEMA_IF_EXISTS, TEST_SCHEMA_NAME);
      GetCollectionSakilaXMovies = string.Format(GET_COLLECTION, SAKILA_X_SCHEMA_NAME, SAKILA_X_MOVIES_COLLECTION);
      GetCollectionSakilaXUser = string.Format(GET_COLLECTION, SAKILA_X_SCHEMA_NAME, SAKILA_X_USERS_COLLECTION);
      GetSchemaSakilaX = string.Format(GET_SCHEMA, SAKILA_X_SCHEMA_NAME);
      GetSchemaTest = string.Format(GET_SCHEMA, TEST_SCHEMA_NAME);
      GetCollectionTestSchemaTest = string.Format(GET_COLLECTION, TEST_SCHEMA_NAME, TEST_COLLECTION_NAME);
    }
  }
}
