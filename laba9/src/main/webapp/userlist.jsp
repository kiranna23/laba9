<%@page language="java" contentType="text/html; charset=UTF-8"
        pageEncoding="UTF-8"%>
<%@taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@taglib prefix="my" tagdir="/WEB-INF/tags"%>
<%@taglib prefix="ad" uri="http://tag/ad"%>
<c:if test="${sessionScope.authUser==null}">
    <c:redirect url="/index.jsp" />
</c:if>
<!DOCTYPE html>
<html>
<head>
    <title>Список пользователей</title>
    <meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />
    <meta http-equiv="Expires" content="Mon, 11 May 1998 0:00:00 GMT">
    <meta http-equiv="Last-Modified" content="Fri, Jan 25 2099 23:59:59 GMT">
</head>
<body>
<jsp:include page="/static/header.jsp"></jsp:include>
<my:newButton />
<h1>Список пользователей</h1>
    <my:layout1Column>


        <my:UserList UserList="${UserList}"  />
    </my:layout1Column>
<%@ include file="/static/footer.jsp"%>
</body>
</html>