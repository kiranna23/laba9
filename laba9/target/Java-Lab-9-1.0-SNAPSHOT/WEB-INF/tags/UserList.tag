<%@ tag pageEncoding="UTF-8"%>
<%-- Импортировать JSTL-библиотеки --%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@taglib prefix="my" tagdir="/WEB-INF/tags"%>
<%-- Коллекция объявлений для показа --%>
<%@attribute name="UserList" required="true" rtexprvalue="true" type="java.util.AbstractCollection"%>

<%-- Таблица с заголовками показывается только если в списке есть хотя бы одно объявление --%>
<c:if test="${UserList!=null}">
	<table><%--//! border="0" cellpadding="5" cellspacing="1">--%>
		<tr bgcolor="#cccccc" align="center">
			<td>Имя<br> <c:out value="${sessionScope.authUser.name}" />
		</tr>
					<%-- Организовать цикл по всем объявлениям из коллекции  --%>

	</table>
</c:if>
